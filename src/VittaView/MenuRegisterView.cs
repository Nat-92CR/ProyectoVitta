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

        /// <summary>
        /// Inicializa una nueva instancia de la clase MenuRegisterView.
        /// </summary>
        public MenuRegisterView()
        {
            this.InitializeComponent();
            this.currentUserName = string.Empty;
            this.isEditMode = false;
            this.selectedOriginalMenuDate = DateTime.MinValue;
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

            var selectedFoodName = this.cmbAvailableFoods.SelectedItem.ToString() ?? string.Empty;
            var selectedMealTime = this.cmbMealTime.SelectedItem.ToString() ?? string.Empty;
            var quantity = Convert.ToInt32(this.nudQuantity.Value);

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

            if (quantity <= 0)
            {
                MessageBox.Show("La cantidad debe ser mayor que cero.");
                return;
            }

            var foodText = selectedFoodName + " x" + quantity;

            if (this.ContainsComma(foodText))
            {
                MessageBox.Show("No se permiten comas porque el sistema guarda la información en archivo CSV.");
                return;
            }

            this.AddFoodToSelectedMealTime(selectedMealTime, foodText);
            this.FillPreviewFromMealTextFields();
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

            var menu = new Menu(
                this.currentUserName,
                this.dtpMenuDate.Value.Date,
                breakfast,
                morningSnack,
                lunch,
                afternoonSnack,
                dinner);

            var result = this.menuController!.RegisterMenu(menu);

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

            var selectedDateText = this.cmbExistingMenus.SelectedItem.ToString() ?? string.Empty;

            if (!DateTime.TryParseExact(selectedDateText, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime selectedDate))
            {
                MessageBox.Show("No se pudo interpretar la fecha del menú seleccionado.");
                return;
            }

            var selectedMenu = this.menuController.GetMenuByUserAndDate(this.currentUserName, selectedDate);

            if (selectedMenu == null)
            {
                MessageBox.Show("No se encontró el menú seleccionado.");
                return;
            }

            this.LoadMenuIntoForm(selectedMenu);
            this.isEditMode = true;
            this.selectedOriginalMenuDate = selectedMenu.MenuDate.Date;
            this.FillPreviewFromMealTextFields();
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

            var updatedMenu = new Menu(
                this.currentUserName,
                this.dtpMenuDate.Value.Date,
                breakfast,
                morningSnack,
                lunch,
                afternoonSnack,
                dinner);

            var result = this.menuController.UpdateMenu(this.currentUserName, this.selectedOriginalMenuDate, updatedMenu);

            if (result)
            {
                MessageBox.Show("El menú se actualizó correctamente.");
                this.isEditMode = true;
                this.selectedOriginalMenuDate = updatedMenu.MenuDate.Date;
                this.LoadExistingMenus();
                this.SelectExistingMenuByDate(updatedMenu.MenuDate.Date);
                this.FillPreviewFromMealTextFields();
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

                var selectedDateText = this.cmbExistingMenus.SelectedItem.ToString() ?? string.Empty;

                if (!DateTime.TryParseExact(selectedDateText, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out targetDate))
                {
                    MessageBox.Show("No se pudo interpretar la fecha del menú seleccionado.");
                    return;
                }
            }

            var confirmation = MessageBox.Show(
                "¿Está seguro de que desea eliminar este menú?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirmation != DialogResult.Yes)
            {
                return;
            }

            var result = this.menuController.DeleteMenu(this.currentUserName, targetDate);

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
        /// Evento que reacciona cuando cambia el contenido de un tiempo de comida.
        /// </summary>
        private void MealTextFields_TextChanged(object sender, EventArgs e)
        {
            this.FillPreviewFromMealTextFields();
            this.RefreshNutritionalResults();
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

            this.txtTotalCalories.ReadOnly = true;
            this.txtTotalProtein.ReadOnly = true;
            this.txtTotalCarbohydrates.ReadOnly = true;
            this.txtTotalFat.ReadOnly = true;

            this.ShowNutritionTotals(0, 0, 0, 0);
        }

        /// <summary>
        /// Asocia eventos de cambio a los tiempos de comida.
        /// </summary>
        private void AttachMealTextChangedEvents()
        {
            this.txtBreakfast.TextChanged += this.MealTextFields_TextChanged;
            this.textMorning.TextChanged += this.MealTextFields_TextChanged;
            this.txtLunch.TextChanged += this.MealTextFields_TextChanged;
            this.txtAfternoonSnack.TextChanged += this.MealTextFields_TextChanged;
            this.txtDinner.TextChanged += this.MealTextFields_TextChanged;
        }

        /// <summary>
        /// Carga la información de un menú en el formulario.
        /// </summary>
        /// <param name="menu">Menú a cargar.</param>
        private void LoadMenuIntoForm(Menu menu)
        {
            this.dtpMenuDate.Value = menu.MenuDate;
            this.txtBreakfast.Text = menu.Breakfast;
            this.textMorning.Text = menu.MorningSnack;
            this.txtLunch.Text = menu.Lunch;
            this.txtAfternoonSnack.Text = menu.AfternoonSnack;
            this.txtDinner.Text = menu.Dinner;
        }

        /// <summary>
        /// Agrega el alimento al tiempo de comida seleccionado.
        /// </summary>
        /// <param name="mealTime">Tiempo de comida.</param>
        /// <param name="foodText">Texto del alimento a agregar.</param>
        private void AddFoodToSelectedMealTime(string mealTime, string foodText)
        {
            if (mealTime == "Desayuno")
            {
                this.txtBreakfast.Text = this.AppendFood(this.txtBreakfast.Text, foodText);
            }
            else if (mealTime == "Merienda mañana")
            {
                this.textMorning.Text = this.AppendFood(this.textMorning.Text, foodText);
            }
            else if (mealTime == "Almuerzo")
            {
                this.txtLunch.Text = this.AppendFood(this.txtLunch.Text, foodText);
            }
            else if (mealTime == "Merienda tarde")
            {
                this.txtAfternoonSnack.Text = this.AppendFood(this.txtAfternoonSnack.Text, foodText);
            }
            else if (mealTime == "Cena")
            {
                this.txtDinner.Text = this.AppendFood(this.txtDinner.Text, foodText);
            }
        }

        /// <summary>
        /// Agrega un alimento al texto actual del tiempo de comida.
        /// </summary>
        /// <param name="currentText">Texto actual.</param>
        /// <param name="foodText">Nuevo alimento.</param>
        /// <returns>Texto combinado.</returns>
        private string AppendFood(string currentText, string foodText)
        {
            if (string.IsNullOrWhiteSpace(currentText))
            {
                return foodText;
            }

            return currentText + " | " + foodText;
        }

        /// <summary>
        /// Llena el resumen visual con el contenido actual del menú.
        /// </summary>
        private void FillPreviewFromMealTextFields()
        {
            this.lstMenuPreview.Items.Clear();
            this.AddPreviewItemsFromMealText("Desayuno", this.txtBreakfast.Text);
            this.AddPreviewItemsFromMealText("Merienda mañana", this.textMorning.Text);
            this.AddPreviewItemsFromMealText("Almuerzo", this.txtLunch.Text);
            this.AddPreviewItemsFromMealText("Merienda tarde", this.txtAfternoonSnack.Text);
            this.AddPreviewItemsFromMealText("Cena", this.txtDinner.Text);
        }

        /// <summary>
        /// Agrega los elementos de un tiempo de comida al resumen visual.
        /// </summary>
        /// <param name="mealTime">Tiempo de comida.</param>
        /// <param name="mealText">Texto del tiempo de comida.</param>
        private void AddPreviewItemsFromMealText(string mealTime, string mealText)
        {
            if (string.IsNullOrWhiteSpace(mealText))
            {
                return;
            }

            string[] mealItems = mealText.Split(new string[] { " | " }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string mealItem in mealItems)
            {
                this.lstMenuPreview.Items.Add(mealTime + ": " + mealItem);
            }
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

            string[] mealItems = mealText.Split(new string[] { " | " }, StringSplitOptions.RemoveEmptyEntries);

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
            breakfast = this.txtBreakfast.Text.Trim();
            morningSnack = this.textMorning.Text.Trim();
            lunch = this.txtLunch.Text.Trim();
            afternoonSnack = this.txtAfternoonSnack.Text.Trim();
            dinner = this.txtDinner.Text.Trim();

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
        }

        /// <summary>
        /// Carga la información de un menú en el formulario.
        /// </summary>
        /// <param name="menu">Menú a cargar.</param>
        private void LoadMenuIntoForm(Menu menu)
        {
            this.dtpMenuDate.Value = menu.MenuDate;
            this.txtBreakfast.Text = menu.Breakfast;
            this.textMorning.Text = menu.MorningSnack;
            this.txtLunch.Text = menu.Lunch;
            this.txtAfternoonSnack.Text = menu.AfternoonSnack;
            this.txtDinner.Text = menu.Dinner;
        }

        /// <summary>
        /// Agrega el alimento al tiempo de comida seleccionado.
        /// </summary>
        /// <param name="mealTime">Tiempo de comida.</param>
        /// <param name="foodText">Texto del alimento a agregar.</param>
        private void AddFoodToSelectedMealTime(string mealTime, string foodText)
        {
            if (mealTime == "Desayuno")
            {
                this.txtBreakfast.Text = this.AppendFood(this.txtBreakfast.Text, foodText);
            }
            else if (mealTime == "Merienda mañana")
            {
                this.textMorning.Text = this.AppendFood(this.textMorning.Text, foodText);
            }
            else if (mealTime == "Almuerzo")
            {
                this.txtLunch.Text = this.AppendFood(this.txtLunch.Text, foodText);
            }
            else if (mealTime == "Merienda tarde")
            {
                this.txtAfternoonSnack.Text = this.AppendFood(this.txtAfternoonSnack.Text, foodText);
            }
            else if (mealTime == "Cena")
            {
                this.txtDinner.Text = this.AppendFood(this.txtDinner.Text, foodText);
            }
        }

        /// <summary>
        /// Agrega un alimento al texto actual del tiempo de comida.
        /// </summary>
        /// <param name="currentText">Texto actual.</param>
        /// <param name="foodText">Nuevo alimento.</param>
        /// <returns>Texto combinado.</returns>
        private string AppendFood(string currentText, string foodText)
        {
            if (string.IsNullOrWhiteSpace(currentText))
            {
                return foodText;
            }

            return currentText + " | " + foodText;
        }

        /// <summary>
        /// Llena el resumen visual con el contenido actual del menú.
        /// </summary>
        private void FillPreviewFromMealTextFields()
        {
            this.lstMenuPreview.Items.Clear();
            this.AddPreviewItemsFromMealText("Desayuno", this.txtBreakfast.Text);
            this.AddPreviewItemsFromMealText("Merienda mañana", this.textMorning.Text);
            this.AddPreviewItemsFromMealText("Almuerzo", this.txtLunch.Text);
            this.AddPreviewItemsFromMealText("Merienda tarde", this.txtAfternoonSnack.Text);
            this.AddPreviewItemsFromMealText("Cena", this.txtDinner.Text);
        }

        /// <summary>
        /// Agrega los elementos de un tiempo de comida al resumen visual.
        /// </summary>
        /// <param name="mealTime">Tiempo de comida.</param>
        /// <param name="mealText">Texto del tiempo de comida.</param>
        private void AddPreviewItemsFromMealText(string mealTime, string mealText)
        {
            if (string.IsNullOrWhiteSpace(mealText))
            {
                return;
            }

            string[] mealItems = mealText.Split(new string[] { " | " }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string mealItem in mealItems)
            {
                this.lstMenuPreview.Items.Add(mealTime + ": " + mealItem);
            }
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
            breakfast = this.txtBreakfast.Text.Trim();
            morningSnack = this.textMorning.Text.Trim();
            lunch = this.txtLunch.Text.Trim();
            afternoonSnack = this.txtAfternoonSnack.Text.Trim();
            dinner = this.txtDinner.Text.Trim();

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
        /// Limpia los campos del formulario.
        /// </summary>
        private void ClearFields()
        {
            this.txtBreakfast.Clear();
            this.textMorning.Clear();
            this.txtLunch.Clear();
            this.txtAfternoonSnack.Clear();
            this.txtDinner.Clear();
            this.lstMenuPreview.Items.Clear();
            this.dtpMenuDate.Value = DateTime.Now;
            this.ResetFoodSelectionFields();
            this.cmbExistingMenus.SelectedIndex = -1;
            this.isEditMode = false;
            this.selectedOriginalMenuDate = DateTime.MinValue;
            this.ShowNutritionTotals(0, 0, 0, 0);
            this.txtBreakfast.Focus();
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