namespace VittaView
{
    using System;
    using System.Collections.Generic;
    using System.Windows.Forms;
    using VittaController.Abstractions;
    using VittaModel;
    using static System.Windows.Forms.VisualStyles.VisualStyleElement;

    /// <summary>
    /// Vista encargada de consultar los alimentos registrados en el sistema.
    /// </summary>
    public partial class FoodConsultView : Form
    {
        private readonly IFoodController foodController;

        /// <summary>
        /// Inicializa una nueva instancia de la clase FoodConsultView.
        /// </summary>
        /// <param name="foodController">Controlador de alimentos.</param>
        public FoodConsultView(IFoodController foodController)
        {
            InitializeComponent();
            this.foodController = foodController;
        }

        private void FoodConsultView_Load(object sender, EventArgs e)
        {
            this.ConfigureDataGridView();
            this.LoadFoods(this.foodController.GetFoods());
        }


        
        /// Dentro de ese código hay dos métodos privados nuevos:
        ///1. ConfigureDataGridView() Configura las columnas de la tabla. 2. LoadFoods(List<Food> foods) Ese es el de cargar alimentos que decías que no tenías.
      
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

            foreach (var food in foods)
            {
                this.dgvFoods.Rows.Add(
                    food.Name,
                    food.Calories,
                    food.Protein,
                    food.Carbohydrates,
                    food.Fat);
            }
        }

        ///Eventos los BOTONES de búsqueda, mostrar todo y cerrar la vista.
        private void btnSearch_Click(object sender, EventArgs e)
        {
            var foods = this.foodController.SearchFoodsByName(this.txtSearchFood.Text);
            this.LoadFoods(foods);
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            this.txtSearchFood.Clear();
            this.LoadFoods(this.foodController.GetFoods());
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}