namespace VittaView
{
    using System;
    using System.Collections.Generic;
    using System.Windows.Forms;
    using VittaController.Abstractions;
    using VittaModel;

    /// <summary>
    /// Vista encargada de consultar, eliminar y actualizar los alimentos registrados en el sistema.
    /// </summary>
    public partial class FoodConsultView : Form
    {
        private readonly IFoodController foodController;
        private string selectedFoodName;

        /// <summary>
        /// Inicializa una nueva instancia de la clase FoodConsultView.
        /// </summary>
        /// <param name="foodController">Controlador de alimentos.</param>
        public FoodConsultView(IFoodController foodController)
        {
            this.InitializeComponent();
            this.foodController = foodController;
            this.selectedFoodName = string.Empty;

            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void FoodConsultView_Load(object sender, EventArgs e)
        {
            this.ConfigureDataGridView();
            this.LoadFoods(this.foodController.GetFoods());
            this.ClearEditFields();
        }

        private void ConfigureDataGridView()
        {
            this.dgvFoods.AutoGenerateColumns = false;
            this.dgvFoods.Columns.Clear();

            this.dgvFoods.Columns.Add("Name", "Nombre");
            this.dgvFoods.Columns.Add("Calories", "Calorías");
            this.dgvFoods.Columns.Add("Protein", "Proteínas");
            this.dgvFoods.Columns.Add("Carbohydrates", "Carbohidratos");
            this.dgvFoods.Columns.Add("Fat", "Grasas");
        }

        private void LoadFoods(List<Food> foods)
        {
            this.dgvFoods.Rows.Clear();

            foreach (Food food in foods)
            {
                this.dgvFoods.Rows.Add(
                    food.Name,
                    food.Calories,
                    food.Protein,
                    food.Carbohydrates,
                    food.Fat);
            }
        }

        private void ClearEditFields()
        {
            this.selectedFoodName = string.Empty;
            this.txtEditName.Clear();
            this.txtEditCalories.Clear();
            this.txtEditProtein.Clear();
            this.txtEditCarbohydrates.Clear();
            this.txtEditFat.Clear();
        }

        private void dgvFoods_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            DataGridViewRow selectedRow = this.dgvFoods.Rows[e.RowIndex];

            this.selectedFoodName = selectedRow.Cells[0].Value?.ToString() ?? string.Empty;
            this.txtEditName.Text = this.selectedFoodName;
            this.txtEditCalories.Text = selectedRow.Cells[1].Value?.ToString() ?? string.Empty;
            this.txtEditProtein.Text = selectedRow.Cells[2].Value?.ToString() ?? string.Empty;
            this.txtEditCarbohydrates.Text = selectedRow.Cells[3].Value?.ToString() ?? string.Empty;
            this.txtEditFat.Text = selectedRow.Cells[4].Value?.ToString() ?? string.Empty;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            List<Food> foods = this.foodController.SearchFoodsByName(this.txtSearchFood.Text);
            this.LoadFoods(foods);
            this.ClearEditFields();
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            this.txtSearchFood.Clear();
            this.LoadFoods(this.foodController.GetFoods());
            this.ClearEditFields();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (this.dgvFoods.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un alimento para eliminar.");
                return;
            }

            string foodName = this.dgvFoods.SelectedRows[0].Cells[0].Value?.ToString() ?? string.Empty;

            if (string.IsNullOrWhiteSpace(foodName))
            {
                MessageBox.Show("No se pudo obtener el nombre del alimento seleccionado.");
                return;
            }

            DialogResult result = MessageBox.Show(
                $"¿Desea eliminar el alimento '{foodName}'?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                bool isDeleted = this.foodController.DeleteFood(foodName);

                if (isDeleted)
                {
                    MessageBox.Show("El alimento se eliminó correctamente.");
                    this.txtSearchFood.Clear();
                    this.LoadFoods(this.foodController.GetFoods());
                    this.ClearEditFields();
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar el alimento.");
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            double calories;
            double protein;
            double carbohydrates;
            double fat;

            if (string.IsNullOrWhiteSpace(this.selectedFoodName))
            {
                MessageBox.Show("Seleccione un alimento para editar.");
                return;
            }

            if (!double.TryParse(this.txtEditCalories.Text, out calories) ||
                !double.TryParse(this.txtEditProtein.Text, out protein) ||
                !double.TryParse(this.txtEditCarbohydrates.Text, out carbohydrates) ||
                !double.TryParse(this.txtEditFat.Text, out fat))
            {
                MessageBox.Show("Las calorías, proteínas, carbohidratos y grasas deben ser valores numéricos válidos.");
                return;
            }

            if (calories < 0 || protein < 0 || carbohydrates < 0 || fat < 0)
            {
                MessageBox.Show("Los valores nutricionales no pueden ser negativos.");
                return;
            }

            Food updatedFood = new Food(
                this.selectedFoodName,
                calories,
                protein,
                carbohydrates,
                fat);

            bool isUpdated = this.foodController.UpdateFood(updatedFood);

            if (isUpdated)
            {
                MessageBox.Show("El alimento se actualizó correctamente.");
                this.txtSearchFood.Clear();
                this.LoadFoods(this.foodController.GetFoods());
                this.ClearEditFields();
            }
            else
            {
                MessageBox.Show("No se pudo actualizar el alimento.");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}