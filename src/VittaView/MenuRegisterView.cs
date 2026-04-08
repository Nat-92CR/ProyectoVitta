namespace VittaView
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Windows.Forms;
    using VittaController.Abstractions;
    using VittaModel;

    /// <summary>
    /// Vista encargada del registro de menús dentro del sistema.
    /// </summary>
    public partial class MenuRegisterView : Form
    {
        private readonly IMenuController? menuController;
        private readonly IFoodController? foodController;
        private readonly string currentUserName;
        private bool isEditMode;
        private DateTime selectedOriginalMenuDate;
        private bool suppressDateChangeHandling;
        private string selectedMealItemText;
        private string selectedMealTimeText;

        /// <summary>
        /// Inicializa una nueva instancia de la clase MenuRegisterView.
        /// </summary>
        public MenuRegisterView()
        {
            this.InitializeComponent();
            this.currentUserName = string.Empty;
            this.isEditMode = false;
            this.selectedOriginalMenuDate = DateTime.MinValue;
            this.suppressDateChangeHandling = false;
            this.selectedMealItemText = string.Empty;
            this.selectedMealTimeText = string.Empty;
            this.AttachMealTextChangedEvents();
        }

        /// <summary>
        /// Inicializa una nueva instancia de la clase MenuRegisterView.
        /// </summary>
        /// <param name="menuController">Controlador de menús.</param>
        /// <param name="foodController">Controlador de alimentos.</param>
        /// <param name="currentUserName">Nombre del usuario actual.</param>
        public MenuRegisterView(IMenuController menuController, IFoodController foodController, string currentUserName)
            : this()
        {
            this.menuController = menuController;
            this.foodController = foodController;
            this.currentUserName = currentUserName;
            this.LoadFoods();
            this.LoadMealTimes();
            this.ConfigureInitialState();
            this.LoadExistingMenus();
            this.RefreshNutritionalResults();
        }

        /// <summary>
        /// Evento que se ejecuta al presionar el botón Agregar alimento.
        /// </summary>
        private void btnAddFoodToMenu_Click(object sender, EventArgs e)
        {
            if (this.foodController == null)
            {
                MessageBox.Show("No se pudo cargar el módulo de alimentos.");
                return;
            }

            if (this.cmbAvailableFoods.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un alimento.");
                return;
            }

            if (this.cmbMealTime.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un tiempo de comida.");
                return;
            }

            string selectedFoodName = this.cmbAvailableFoods.SelectedItem.ToString() ?? string.Empty;
            string selectedMealTime = this.cmbMealTime.SelectedItem.ToString() ?? string.Empty;
            int quantityToAdd = Convert.ToInt32(this.nudQuantity.Value);

            if (string.IsNullOrWhiteSpace(selectedFoodName))
            {
                MessageBox.Show("Seleccione un alimento válido.");
                return;
            }

            if (string.IsNullOrWhiteSpace(selectedMealTime))
            {
                MessageBox.Show("Seleccione un tiempo de comida válido.");
                return;
            }

            if (quantityToAdd <= 0)
            {
                MessageBox.Show("La cantidad debe ser mayor que cero.");
                return;
            }

            if (this.ContainsComma(selectedFoodName))
            {
                MessageBox.Show("No se permiten comas porque el sistema guarda la información en archivo CSV.");
                return;
            }

            this.AddFoodToSelectedMealTime(selectedMealTime, selectedFoodName, quantityToAdd);
            this.RefreshNutritionalResults();
            this.ResetFoodSelectionFields();
            this.ClearSelectedMealItem();
        }

        /// <summary>
        /// Evento que quita un alimento específico del menú actual.
        /// </summary>
        private void btnRemoveFoodFromMenu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.selectedMealItemText) || string.IsNullOrWhiteSpace(this.selectedMealTimeText))
            {
                MessageBox.Show("Seleccione un alimento directamente dentro de Desayuno, Mañana, Almuerzo, Tarde o Cena.");
                return;
            }

            this.ParseMealItem(this.selectedMealItemText, out string selectedFoodName, out int selectedQuantity);
            int quantityToRemove = Convert.ToInt32(this.nudQuantity.Value);

            if (string.IsNullOrWhiteSpace(selectedFoodName))
            {
                MessageBox.Show("No se pudo interpretar el alimento seleccionado.");
                return;
            }

            if (quantityToRemove <= 0)
            {
                MessageBox.Show("La cantidad debe ser mayor que cero.");
                return;
            }

            if (quantityToRemove > selectedQuantity)
            {
                MessageBox.Show("La cantidad a quitar no puede ser mayor que la cantidad registrada en la línea seleccionada.");
                return;
            }

            bool removed = this.RemoveFoodFromSelectedMealTime(this.selectedMealTimeText, selectedFoodName, quantityToRemove);

            if (!removed)
            {
                MessageBox.Show("No se pudo quitar el alimento seleccionado.");
                return;
            }

            this.ClearSelectedMealItem();
            this.RefreshNutritionalResults();
            this.ResetFoodSelectionFields();
        }

        /// <summary>
        /// Evento que se ejecuta al presionar el botón Guardar menú.
        /// </summary>
        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (this.isEditMode)
            {
                MessageBox.Show("Está editando un menú existente. Use el botón Actualizar menú para guardar los cambios.");
                return;
            }

            if (!this.TryGetMealTexts(out string breakfast, out string morningSnack, out string lunch, out string afternoonSnack, out string dinner))
            {
                return;
            }

            Menu menu = new Menu(
                this.currentUserName,
                this.dtpMenuDate.Value.Date,
                breakfast,
                morningSnack,
                lunch,
                afternoonSnack,
                dinner);

            bool result = this.menuController!.RegisterMenu(menu);

            if (result)
            {
                MessageBox.Show("El menú se registró correctamente.");
                this.ClearFields();
                this.LoadExistingMenus();
            }
            else
            {
                MessageBox.Show("No fue posible registrar el menú. Verifique si ya existe un menú para esa fecha o si los datos son inválidos.");
            }
        }

        /// <summary>
        /// Evento que carga el menú seleccionado.
        /// </summary>
        private void btnLoadMenu_Click(object sender, EventArgs e)
        {
            if (this.menuController == null)
            {
                MessageBox.Show("No se pudo cargar el módulo de menús.");
                return;
            }

            if (this.cmbExistingMenus.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un menú existente.");
                return;
            }

            string selectedDateText = this.cmbExistingMenus.SelectedItem.ToString() ?? string.Empty;

            if (!DateTime.TryParseExact(selectedDateText, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime selectedDate))
            {
                MessageBox.Show("No se pudo interpretar la fecha del menú seleccionado.");
                return;
            }

            Menu? selectedMenu = this.menuController.GetMenuByUserAndDate(this.currentUserName, selectedDate);

            if (selectedMenu == null)
            {
                MessageBox.Show("No se encontró el menú seleccionado.");
                return;
            }

            this.LoadMenuIntoForm(selectedMenu);
            this.isEditMode = true;
            this.selectedOriginalMenuDate = selectedMenu.MenuDate.Date;
            this.SelectExistingMenuByDate(selectedMenu.MenuDate.Date);
            this.RefreshNutritionalResults();
        }

        /// <summary>
        /// Evento que actualiza un menú existente.
        /// </summary>
        private void btnUpdateMenu_Click(object sender, EventArgs e)
        {
            if (this.menuController == null)
            {
                MessageBox.Show("No se pudo cargar el módulo de menús.");
                return;
            }

            if (!this.isEditMode || this.selectedOriginalMenuDate == DateTime.MinValue)
            {
                MessageBox.Show("Primero debe cargar un menú existente para editarlo.");
                return;
            }

            if (!this.TryGetMealTexts(out string breakfast, out string morningSnack, out string lunch, out string afternoonSnack, out string dinner))
            {
                return;
            }

            Menu updatedMenu = new Menu(
                this.currentUserName,
                this.dtpMenuDate.Value.Date,
                breakfast,
                morningSnack,
                lunch,
                afternoonSnack,
                dinner);

            bool result = this.menuController.UpdateMenu(this.currentUserName, this.selectedOriginalMenuDate, updatedMenu);

            if (result)
            {
                MessageBox.Show("El menú se actualizó correctamente.");
                this.isEditMode = true;
                this.selectedOriginalMenuDate = updatedMenu.MenuDate.Date;
                this.LoadExistingMenus();
                this.SelectExistingMenuByDate(updatedMenu.MenuDate.Date);
                this.RefreshNutritionalResults();
            }
            else
            {
                MessageBox.Show("No fue posible actualizar el menú. Verifique si la nueva fecha ya existe o si los datos son inválidos.");
            }
        }

        /// <summary>
        /// Evento que elimina un menú existente.
        /// </summary>
        private void btnDeleteMenu_Click(object sender, EventArgs e)
        {
            if (this.menuController == null)
            {
                MessageBox.Show("No se pudo cargar el módulo de menús.");
                return;
            }

            DateTime targetDate;

            if (this.isEditMode && this.selectedOriginalMenuDate != DateTime.MinValue)
            {
                targetDate = this.selectedOriginalMenuDate;
            }
            else
            {
                if (this.cmbExistingMenus.SelectedItem == null)
                {
                    MessageBox.Show("Seleccione o cargue un menú para eliminarlo.");
                    return;
                }

                string selectedDateText = this.cmbExistingMenus.SelectedItem.ToString() ?? string.Empty;

                if (!DateTime.TryParseExact(selectedDateText, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out targetDate))
                {
                    MessageBox.Show("No se pudo interpretar la fecha del menú seleccionado.");
                    return;
                }
            }

            DialogResult confirmation = MessageBox.Show(
                "¿Está seguro de que desea eliminar este menú?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirmation != DialogResult.Yes)
            {
                return;
            }

            bool result = this.menuController.DeleteMenu(this.currentUserName, targetDate);

            if (result)
            {
                MessageBox.Show("El menú se eliminó correctamente.");
                this.ClearFields();
                this.LoadExistingMenus();
            }
            else
            {
                MessageBox.Show("No fue posible eliminar el menú seleccionado.");
            }
        }

        /// <summary>
        /// Evento que reacciona cuando cambia la fecha del menú.
        /// </summary>
        private void dtpMenuDate_ValueChanged(object sender, EventArgs e)
        {
            if (this.suppressDateChangeHandling)
            {
                return;
            }

            if (!this.isEditMode)
            {
                return;
            }

            DateTime currentDate = this.dtpMenuDate.Value.Date;

            if (currentDate == this.selectedOriginalMenuDate)
            {
                return;
            }

            this.ClearMealFieldsOnly();
            this.ResetFoodSelectionFields();
            this.ShowNutritionTotals(0, 0, 0, 0);
            this.isEditMode = false;
            this.selectedOriginalMenuDate = DateTime.MinValue;
            this.cmbExistingMenus.SelectedIndex = -1;
            this.ClearSelectedMealItem();
        }

        /// <summary>
        /// Evento que reacciona cuando cambia el contenido de un tiempo de comida.
        /// </summary>
        private void MealTextFields_TextChanged(object sender, EventArgs e)
        {
            this.RefreshNutritionalResults();
        }

        /// <summary>
        /// Evento que detecta un clic dentro de un tiempo de comida.
        /// </summary>
        private void MealTextBox_MouseUp(object sender, MouseEventArgs e)
        {
            TextBox? mealTextBox = sender as TextBox;
            this.SelectCurrentMealItem(mealTextBox);
        }

        /// <summary>
        /// Evento que detecta movimiento del cursor dentro de un tiempo de comida.
        /// </summary>
        private void MealTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            TextBox? mealTextBox = sender as TextBox;
            this.SelectCurrentMealItem(mealTextBox);
        }

        /// <summary>
        /// Carga la lista de alimentos disponibles en el combo.
        /// </summary>
        private void LoadFoods()
        {
            if (this.foodController == null)
            {
                return;
            }

            this.cmbAvailableFoods.Items.Clear();

            List<Food> foods = this.foodController.GetFoods();
            foods.Sort((firstFood, secondFood) => string.Compare(firstFood.Name, secondFood.Name, StringComparison.CurrentCultureIgnoreCase));

            foreach (Food food in foods)
            {
                this.cmbAvailableFoods.Items.Add(food.Name);
            }
        }

        /// <summary>
        /// Carga los tiempos de comida disponibles.
        /// </summary>
        private void LoadMealTimes()
        {
            this.cmbMealTime.Items.Clear();
            this.cmbMealTime.Items.Add("Desayuno");
            this.cmbMealTime.Items.Add("Merienda mañana");
            this.cmbMealTime.Items.Add("Almuerzo");
            this.cmbMealTime.Items.Add("Merienda tarde");
            this.cmbMealTime.Items.Add("Cena");
        }

        /// <summary>
        /// Carga los menús existentes del usuario actual.
        /// </summary>
        private void LoadExistingMenus()
        {
            this.cmbExistingMenus.Items.Clear();

            if (this.menuController == null || string.IsNullOrWhiteSpace(this.currentUserName))
            {
                return;
            }

            List<Menu> userMenus = this.menuController.GetMenusByUser(this.currentUserName);
            userMenus.Sort((firstMenu, secondMenu) => firstMenu.MenuDate.CompareTo(secondMenu.MenuDate));

            foreach (Menu menu in userMenus)
            {
                this.cmbExistingMenus.Items.Add(menu.MenuDate.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture));
            }

            this.cmbExistingMenus.SelectedIndex = -1;
        }

        /// <summary>
        /// Configura el estado inicial de los controles.
        /// </summary>
        private void ConfigureInitialState()
        {
            this.nudQuantity.Minimum = 1;
            this.nudQuantity.Maximum = 20;
            this.nudQuantity.Value = 1;

            this.cmbAvailableFoods.SelectedIndex = -1;
            this.cmbMealTime.SelectedIndex = -1;
            this.cmbExistingMenus.SelectedIndex = -1;

            this.txtBreakfast.ReadOnly = true;
            this.textMorning.ReadOnly = true;
            this.txtLunch.ReadOnly = true;
            this.txtAfternoonSnack.ReadOnly = true;
            this.txtDinner.ReadOnly = true;

            this.txtBreakfast.TabStop = false;
            this.textMorning.TabStop = false;
            this.txtLunch.TabStop = false;
            this.txtAfternoonSnack.TabStop = false;
            this.txtDinner.TabStop = false;

            this.txtBreakfast.HideSelection = false;
            this.textMorning.HideSelection = false;
            this.txtLunch.HideSelection = false;
            this.txtAfternoonSnack.HideSelection = false;
            this.txtDinner.HideSelection = false;

            this.txtTotalCalories.ReadOnly = true;
            this.txtTotalProtein.ReadOnly = true;
            this.txtTotalCarbohydrates.ReadOnly = true;
            this.txtTotalFat.ReadOnly = true;

            this.ShowNutritionTotals(0, 0, 0, 0);
        }

        /// <summary>
        /// Asocia eventos de cambio y selección a los tiempos de comida.
        /// </summary>
        private void AttachMealTextChangedEvents()
        {
            this.txtBreakfast.TextChanged += this.MealTextFields_TextChanged;
            this.textMorning.TextChanged += this.MealTextFields_TextChanged;
            this.txtLunch.TextChanged += this.MealTextFields_TextChanged;
            this.txtAfternoonSnack.TextChanged += this.MealTextFields_TextChanged;
            this.txtDinner.TextChanged += this.MealTextFields_TextChanged;

            this.txtBreakfast.MouseUp += this.MealTextBox_MouseUp;
            this.textMorning.MouseUp += this.MealTextBox_MouseUp;
            this.txtLunch.MouseUp += this.MealTextBox_MouseUp;
            this.txtAfternoonSnack.MouseUp += this.MealTextBox_MouseUp;
            this.txtDinner.MouseUp += this.MealTextBox_MouseUp;

            this.txtBreakfast.KeyUp += this.MealTextBox_KeyUp;
            this.textMorning.KeyUp += this.MealTextBox_KeyUp;
            this.txtLunch.KeyUp += this.MealTextBox_KeyUp;
            this.txtAfternoonSnack.KeyUp += this.MealTextBox_KeyUp;
            this.txtDinner.KeyUp += this.MealTextBox_KeyUp;
        }

        /// <summary>
        /// Selecciona el alimento actual dentro del TextBox correspondiente.
        /// </summary>
        /// <param name="mealTextBox">TextBox del tiempo de comida.</param>
        private void SelectCurrentMealItem(TextBox? mealTextBox)
        {
            if (mealTextBox == null || string.IsNullOrWhiteSpace(mealTextBox.Text))
            {
                this.ClearSelectedMealItem();
                return;
            }

            int lineIndex = mealTextBox.GetLineFromCharIndex(mealTextBox.SelectionStart);

            if (lineIndex < 0 || lineIndex >= mealTextBox.Lines.Length)
            {
                this.ClearSelectedMealItem();
                return;
            }

            string selectedLine = mealTextBox.Lines[lineIndex].Trim();

            if (string.IsNullOrWhiteSpace(selectedLine))
            {
                this.ClearSelectedMealItem();
                return;
            }

            this.ClearMealTextBoxSelections(mealTextBox);

            int lineStart = mealTextBox.GetFirstCharIndexFromLine(lineIndex);
            int lineLength = mealTextBox.Lines[lineIndex].Length;

            if (lineStart >= 0 && lineLength > 0)
            {
                mealTextBox.SelectionStart = lineStart;
                mealTextBox.SelectionLength = lineLength;
            }

            this.selectedMealItemText = selectedLine;
            this.selectedMealTimeText = this.GetMealTimeByTextBox(mealTextBox);

            this.ParseMealItem(selectedLine, out string selectedFoodName, out int selectedQuantity);

            this.cmbMealTime.SelectedItem = this.selectedMealTimeText;

            if (!string.IsNullOrWhiteSpace(selectedFoodName))
            {
                this.cmbAvailableFoods.SelectedItem = selectedFoodName;
            }

            this.nudQuantity.Value = 1;
        }

        /// <summary>
        /// Limpia la selección visual de todos los tiempos de comida excepto el activo.
        /// </summary>
        /// <param name="activeTextBox">TextBox activo.</param>
        private void ClearMealTextBoxSelections(TextBox? activeTextBox)
        {
            this.ClearMealTextBoxSelection(this.txtBreakfast, activeTextBox);
            this.ClearMealTextBoxSelection(this.textMorning, activeTextBox);
            this.ClearMealTextBoxSelection(this.txtLunch, activeTextBox);
            this.ClearMealTextBoxSelection(this.txtAfternoonSnack, activeTextBox);
            this.ClearMealTextBoxSelection(this.txtDinner, activeTextBox);
        }

        /// <summary>
        /// Limpia la selección visual de un TextBox si no es el activo.
        /// </summary>
        /// <param name="mealTextBox">TextBox a limpiar.</param>
        /// <param name="activeTextBox">TextBox activo.</param>
        private void ClearMealTextBoxSelection(TextBox mealTextBox, TextBox? activeTextBox)
        {
            if (mealTextBox != activeTextBox)
            {
                mealTextBox.SelectionStart = 0;
                mealTextBox.SelectionLength = 0;
            }
        }

        /// <summary>
        /// Limpia la selección actual de alimento.
        /// </summary>
        private void ClearSelectedMealItem()
        {
            this.selectedMealItemText = string.Empty;
            this.selectedMealTimeText = string.Empty;
            this.ClearMealTextBoxSelections(null);
        }

        /// <summary>
        /// Obtiene el nombre del tiempo de comida según el TextBox recibido.
        /// </summary>
        /// <param name="mealTextBox">TextBox del tiempo de comida.</param>
        /// <returns>Nombre del tiempo de comida.</returns>
        private string GetMealTimeByTextBox(TextBox mealTextBox)
        {
            if (mealTextBox == this.txtBreakfast)
            {
                return "Desayuno";
            }

            if (mealTextBox == this.textMorning)
            {
                return "Merienda mañana";
            }

            if (mealTextBox == this.txtLunch)
            {
                return "Almuerzo";
            }

            if (mealTextBox == this.txtAfternoonSnack)
            {
                return "Merienda tarde";
            }

            return "Cena";
        }

        /// <summary>
        /// Carga la información de un menú en el formulario.
        /// </summary>
        /// <param name="menu">Menú a cargar.</param>
        private void LoadMenuIntoForm(Menu menu)
        {
            this.suppressDateChangeHandling = true;

            this.dtpMenuDate.Value = menu.MenuDate;
            this.txtBreakfast.Text = this.ConvertStorageTextToDisplay(menu.Breakfast);
            this.textMorning.Text = this.ConvertStorageTextToDisplay(menu.MorningSnack);
            this.txtLunch.Text = this.ConvertStorageTextToDisplay(menu.Lunch);
            this.txtAfternoonSnack.Text = this.ConvertStorageTextToDisplay(menu.AfternoonSnack);
            this.txtDinner.Text = this.ConvertStorageTextToDisplay(menu.Dinner);

            this.suppressDateChangeHandling = false;
            this.ClearSelectedMealItem();
        }

        /// <summary>
        /// Agrega el alimento al tiempo de comida seleccionado.
        /// </summary>
        /// <param name="mealTime">Tiempo de comida.</param>
        /// <param name="foodName">Nombre del alimento.</param>
        /// <param name="quantityToAdd">Cantidad a agregar.</param>
        private void AddFoodToSelectedMealTime(string mealTime, string foodName, int quantityToAdd)
        {
            TextBox mealTextBox = this.GetMealTextBoxByMealTime(mealTime);
            List<string> mealItems = this.GetMealItems(mealTextBox.Text);
            bool updated = false;

            this.ClearSelectedMealItem();

            for (int index = 0; index < mealItems.Count; index++)
            {
                this.ParseMealItem(mealItems[index], out string existingFoodName, out int existingQuantity);

                if (existingFoodName.Equals(foodName, StringComparison.OrdinalIgnoreCase))
                {
                    mealItems[index] = existingFoodName + " x" + (existingQuantity + quantityToAdd);
                    updated = true;
                    break;
                }
            }

            if (!updated)
            {
                mealItems.Add(foodName + " x" + quantityToAdd);
            }

            this.SetMealItems(mealTextBox, mealItems);
        }

        /// <summary>
        /// Quita la cantidad indicada de un alimento dentro del tiempo de comida seleccionado.
        /// </summary>
        /// <param name="mealTime">Tiempo de comida.</param>
        /// <param name="foodName">Nombre del alimento.</param>
        /// <param name="quantityToRemove">Cantidad a quitar.</param>
        /// <returns>True si se quitó correctamente; de lo contrario, false.</returns>
        private bool RemoveFoodFromSelectedMealTime(string mealTime, string foodName, int quantityToRemove)
        {
            TextBox mealTextBox = this.GetMealTextBoxByMealTime(mealTime);
            List<string> mealItems = this.GetMealItems(mealTextBox.Text);

            for (int index = 0; index < mealItems.Count; index++)
            {
                this.ParseMealItem(mealItems[index], out string existingFoodName, out int existingQuantity);

                if (!existingFoodName.Equals(foodName, StringComparison.OrdinalIgnoreCase))
                {
                    continue;
                }

                if (existingQuantity < quantityToRemove)
                {
                    continue;
                }

                int remainingQuantity = existingQuantity - quantityToRemove;

                if (remainingQuantity == 0)
                {
                    mealItems.RemoveAt(index);
                }
                else
                {
                    mealItems[index] = existingFoodName + " x" + remainingQuantity;
                }

                this.SetMealItems(mealTextBox, mealItems);
                return true;
            }

            return false;
        }

        /// <summary>
        /// Obtiene el TextBox correspondiente al tiempo de comida seleccionado.
        /// </summary>
        /// <param name="mealTime">Tiempo de comida.</param>
        /// <returns>TextBox del tiempo de comida.</returns>
        private TextBox GetMealTextBoxByMealTime(string mealTime)
        {
            if (mealTime == "Desayuno")
            {
                return this.txtBreakfast;
            }

            if (mealTime == "Merienda mañana")
            {
                return this.textMorning;
            }

            if (mealTime == "Almuerzo")
            {
                return this.txtLunch;
            }

            if (mealTime == "Merienda tarde")
            {
                return this.txtAfternoonSnack;
            }

            return this.txtDinner;
        }

        /// <summary>
        /// Obtiene la lista de alimentos de un tiempo de comida.
        /// </summary>
        /// <param name="mealText">Texto del tiempo de comida.</param>
        /// <returns>Lista de alimentos.</returns>
        private List<string> GetMealItems(string mealText)
        {
            List<string> items = new List<string>();

            if (string.IsNullOrWhiteSpace(mealText))
            {
                return items;
            }

            string normalizedText = mealText
                .Replace("\r\n", "|")
                .Replace("\n", "|")
                .Replace("\r", "|");

            string[] parts = normalizedText.Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string part in parts)
            {
                string cleanItem = part.Trim();

                if (!string.IsNullOrWhiteSpace(cleanItem))
                {
                    items.Add(cleanItem);
                }
            }

            return items;
        }

        /// <summary>
        /// Asigna la lista de alimentos al TextBox del tiempo de comida.
        /// </summary>
        /// <param name="mealTextBox">TextBox a actualizar.</param>
        /// <param name="mealItems">Lista de alimentos.</param>
        private void SetMealItems(TextBox mealTextBox, List<string> mealItems)
        {
            mealTextBox.Text = string.Join(Environment.NewLine, mealItems);
        }

        /// <summary>
        /// Convierte el texto almacenado del menú al formato visual del formulario.
        /// </summary>
        /// <param name="storageText">Texto almacenado.</param>
        /// <returns>Texto listo para mostrar.</returns>
        private string ConvertStorageTextToDisplay(string storageText)
        {
            List<string> mealItems = this.GetMealItems(storageText);
            return string.Join(Environment.NewLine, mealItems);
        }

        /// <summary>
        /// Convierte el texto visual del formulario al formato que se guarda en archivo.
        /// </summary>
        /// <param name="displayText">Texto visual.</param>
        /// <returns>Texto listo para guardar.</returns>
        private string ConvertDisplayTextToStorage(string displayText)
        {
            List<string> mealItems = this.GetMealItems(displayText);
            return string.Join(" | ", mealItems);
        }

        /// <summary>
        /// Calcula los totales nutricionales del menú actual.
        /// </summary>
        private void RefreshNutritionalResults()
        {
            if (this.foodController == null)
            {
                this.ShowNutritionTotals(0, 0, 0, 0);
                return;
            }

            double totalCalories = 0;
            double totalProtein = 0;
            double totalCarbohydrates = 0;
            double totalFat = 0;

            this.AddNutritionFromMealText(this.txtBreakfast.Text, ref totalCalories, ref totalProtein, ref totalCarbohydrates, ref totalFat);
            this.AddNutritionFromMealText(this.textMorning.Text, ref totalCalories, ref totalProtein, ref totalCarbohydrates, ref totalFat);
            this.AddNutritionFromMealText(this.txtLunch.Text, ref totalCalories, ref totalProtein, ref totalCarbohydrates, ref totalFat);
            this.AddNutritionFromMealText(this.txtAfternoonSnack.Text, ref totalCalories, ref totalProtein, ref totalCarbohydrates, ref totalFat);
            this.AddNutritionFromMealText(this.txtDinner.Text, ref totalCalories, ref totalProtein, ref totalCarbohydrates, ref totalFat);

            this.ShowNutritionTotals(totalCalories, totalProtein, totalCarbohydrates, totalFat);
        }

        /// <summary>
        /// Suma la información nutricional de un tiempo de comida.
        /// </summary>
        /// <param name="mealText">Texto del tiempo de comida.</param>
        /// <param name="totalCalories">Acumulado de calorías.</param>
        /// <param name="totalProtein">Acumulado de proteínas.</param>
        /// <param name="totalCarbohydrates">Acumulado de carbohidratos.</param>
        /// <param name="totalFat">Acumulado de grasas.</param>
        private void AddNutritionFromMealText(
            string mealText,
            ref double totalCalories,
            ref double totalProtein,
            ref double totalCarbohydrates,
            ref double totalFat)
        {
            if (string.IsNullOrWhiteSpace(mealText) || this.foodController == null)
            {
                return;
            }

            List<string> mealItems = this.GetMealItems(mealText);

            foreach (string mealItem in mealItems)
            {
                this.ParseMealItem(mealItem.Trim(), out string foodName, out int quantity);

                Food? matchedFood = this.FindFoodByName(foodName);

                if (matchedFood != null)
                {
                    totalCalories += matchedFood.Calories * quantity;
                    totalProtein += matchedFood.Protein * quantity;
                    totalCarbohydrates += matchedFood.Carbohydrates * quantity;
                    totalFat += matchedFood.Fat * quantity;
                }
            }
        }

        /// <summary>
        /// Interpreta el nombre del alimento y la cantidad dentro del texto del menú.
        /// </summary>
        /// <param name="mealItem">Texto del alimento.</param>
        /// <param name="foodName">Nombre del alimento.</param>
        /// <param name="quantity">Cantidad detectada.</param>
        private void ParseMealItem(string mealItem, out string foodName, out int quantity)
        {
            foodName = mealItem.Trim();
            quantity = 1;

            int quantityMarkerIndex = foodName.LastIndexOf(" x", StringComparison.OrdinalIgnoreCase);

            if (quantityMarkerIndex > -1)
            {
                string possibleFoodName = foodName.Substring(0, quantityMarkerIndex).Trim();
                string possibleQuantityText = foodName.Substring(quantityMarkerIndex + 2).Trim();

                if (!string.IsNullOrWhiteSpace(possibleFoodName) &&
                    int.TryParse(possibleQuantityText, out int parsedQuantity) &&
                    parsedQuantity > 0)
                {
                    foodName = possibleFoodName;
                    quantity = parsedQuantity;
                }
            }
        }

        /// <summary>
        /// Busca un alimento por nombre dentro del catálogo existente.
        /// </summary>
        /// <param name="foodName">Nombre del alimento.</param>
        /// <returns>Alimento encontrado o null si no existe.</returns>
        private Food? FindFoodByName(string foodName)
        {
            if (this.foodController == null || string.IsNullOrWhiteSpace(foodName))
            {
                return null;
            }

            List<Food> foods = this.foodController.GetFoods();

            foreach (Food food in foods)
            {
                if (food.Name.Equals(foodName, StringComparison.OrdinalIgnoreCase))
                {
                    return food;
                }
            }

            return null;
        }

        /// <summary>
        /// Muestra en pantalla los totales nutricionales del menú.
        /// </summary>
        /// <param name="totalCalories">Calorías totales.</param>
        /// <param name="totalProtein">Proteínas totales.</param>
        /// <param name="totalCarbohydrates">Carbohidratos totales.</param>
        /// <param name="totalFat">Grasas totales.</param>
        private void ShowNutritionTotals(
            double totalCalories,
            double totalProtein,
            double totalCarbohydrates,
            double totalFat)
        {
            this.txtTotalCalories.Text = totalCalories.ToString("0.##", CultureInfo.InvariantCulture);
            this.txtTotalProtein.Text = totalProtein.ToString("0.##", CultureInfo.InvariantCulture);
            this.txtTotalCarbohydrates.Text = totalCarbohydrates.ToString("0.##", CultureInfo.InvariantCulture);
            this.txtTotalFat.Text = totalFat.ToString("0.##", CultureInfo.InvariantCulture);
        }

        /// <summary>
        /// Intenta obtener y validar los textos de comida del formulario.
        /// </summary>
        /// <param name="breakfast">Desayuno.</param>
        /// <param name="morningSnack">Merienda mañana.</param>
        /// <param name="lunch">Almuerzo.</param>
        /// <param name="afternoonSnack">Merienda tarde.</param>
        /// <param name="dinner">Cena.</param>
        /// <returns>True si los datos son válidos; de lo contrario, false.</returns>
        private bool TryGetMealTexts(
            out string breakfast,
            out string morningSnack,
            out string lunch,
            out string afternoonSnack,
            out string dinner)
        {
            breakfast = this.ConvertDisplayTextToStorage(this.txtBreakfast.Text);
            morningSnack = this.ConvertDisplayTextToStorage(this.textMorning.Text);
            lunch = this.ConvertDisplayTextToStorage(this.txtLunch.Text);
            afternoonSnack = this.ConvertDisplayTextToStorage(this.txtAfternoonSnack.Text);
            dinner = this.ConvertDisplayTextToStorage(this.txtDinner.Text);

            if (this.menuController == null || string.IsNullOrWhiteSpace(this.currentUserName))
            {
                MessageBox.Show("No se pudo asociar el menú al usuario actual.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(breakfast) &&
                string.IsNullOrWhiteSpace(morningSnack) &&
                string.IsNullOrWhiteSpace(lunch) &&
                string.IsNullOrWhiteSpace(afternoonSnack) &&
                string.IsNullOrWhiteSpace(dinner))
            {
                MessageBox.Show("Debe registrar al menos un tiempo de comida.");
                return false;
            }

            if (this.ContainsComma(breakfast) ||
                this.ContainsComma(morningSnack) ||
                this.ContainsComma(lunch) ||
                this.ContainsComma(afternoonSnack) ||
                this.ContainsComma(dinner))
            {
                MessageBox.Show("No se permiten comas en los tiempos de comida porque el sistema guarda la información en archivo CSV.");
                return false;
            }

            return true;
        }

        /// <summary>
        /// Selecciona en el combo el menú correspondiente a la fecha indicada.
        /// </summary>
        /// <param name="menuDate">Fecha del menú.</param>
        private void SelectExistingMenuByDate(DateTime menuDate)
        {
            string menuDateText = menuDate.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);

            for (int index = 0; index < this.cmbExistingMenus.Items.Count; index++)
            {
                if (this.cmbExistingMenus.Items[index] != null &&
                    this.cmbExistingMenus.Items[index]!.ToString() == menuDateText)
                {
                    this.cmbExistingMenus.SelectedIndex = index;
                    return;
                }
            }

            this.cmbExistingMenus.SelectedIndex = -1;
        }

        /// <summary>
        /// Limpia los controles relacionados con la selección de alimentos.
        /// </summary>
        private void ResetFoodSelectionFields()
        {
            this.cmbAvailableFoods.SelectedIndex = -1;
            this.cmbMealTime.SelectedIndex = -1;
            this.nudQuantity.Value = 1;
        }

        /// <summary>
        /// Limpia únicamente los tiempos de comida.
        /// </summary>
        private void ClearMealFieldsOnly()
        {
            this.txtBreakfast.Clear();
            this.textMorning.Clear();
            this.txtLunch.Clear();
            this.txtAfternoonSnack.Clear();
            this.txtDinner.Clear();
            this.ClearSelectedMealItem();
        }

        /// <summary>
        /// Limpia los campos del formulario.
        /// </summary>
        private void ClearFields()
        {
            this.suppressDateChangeHandling = true;
            this.dtpMenuDate.Value = DateTime.Now;
            this.suppressDateChangeHandling = false;

            this.ClearMealFieldsOnly();
            this.ResetFoodSelectionFields();
            this.cmbExistingMenus.SelectedIndex = -1;
            this.isEditMode = false;
            this.selectedOriginalMenuDate = DateTime.MinValue;
            this.ShowNutritionTotals(0, 0, 0, 0);
            this.cmbAvailableFoods.Focus();
        }

        /// <summary>
        /// Verifica si el texto contiene comas.
        /// </summary>
        /// <param name="text">Texto a validar.</param>
        /// <returns>True si contiene comas; de lo contrario, false.</returns>
        private bool ContainsComma(string text)
        {
            return !string.IsNullOrEmpty(text) && text.Contains(",");
        }

        /// <summary>
        /// Evento que se ejecuta al presionar el botón Cancelar.
        /// </summary>
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}