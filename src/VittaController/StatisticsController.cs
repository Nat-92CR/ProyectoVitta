namespace VittaController
{
    using System;
    using System.Collections.Generic;
    using VittaController.Abstractions;
    using VittaModel;

    /// <summary>
    /// Controlador encargado de calcular estadísticas nutricionales del usuario.
    /// </summary>
    public class StatisticsController : IStatisticsController
    {
        private readonly LoginController loginController;
        private readonly IFoodController foodController;
        private readonly IMenuController menuController;
        private readonly INutritionInfoController nutritionInfoController;

        /// <summary>
        /// Inicializa una nueva instancia de la clase StatisticsController.
        /// </summary>
        /// <param name="loginController">Controlador de login.</param>
        /// <param name="foodController">Controlador de alimentos.</param>
        /// <param name="menuController">Controlador de menús.</param>
        /// <param name="nutritionInfoController">Controlador de información nutricional.</param>
        public StatisticsController(
            LoginController loginController,
            IFoodController foodController,
            IMenuController menuController,
            INutritionInfoController nutritionInfoController)
        {
            this.loginController = loginController;
            this.foodController = foodController;
            this.menuController = menuController;
            this.nutritionInfoController = nutritionInfoController;
        }

        /// <summary>
        /// Obtiene un usuario por su nombre de usuario.
        /// </summary>
        /// <param name="username">Nombre de usuario.</param>
        /// <returns>Usuario encontrado o null.</returns>
        public User? GetUserByUserName(string username)
        {
            if (string.IsNullOrWhiteSpace(username))
            {
                return null;
            }

            return this.loginController.GetUserByUserName(username);
        }

        /// <summary>
        /// Obtiene los menús de un usuario dentro de un rango de fechas.
        /// </summary>
        /// <param name="userName">Nombre del usuario.</param>
        /// <param name="startDate">Fecha inicial.</param>
        /// <param name="endDate">Fecha final.</param>
        /// <returns>Lista de menús encontrados.</returns>
        public List<Menu> GetMenusByDateRange(string userName, DateTime startDate, DateTime endDate)
        {
            var menusInRange = new List<Menu>();

            if (string.IsNullOrWhiteSpace(userName))
            {
                return menusInRange;
            }

            List<Menu> userMenus = this.menuController.GetMenusByUser(userName);

            foreach (Menu menu in userMenus)
            {
                if (menu.MenuDate.Date >= startDate.Date && menu.MenuDate.Date <= endDate.Date)
                {
                    menusInRange.Add(menu);
                }
            }

            return menusInRange;
        }

        /// <summary>
        /// Calcula el consumo nutricional total de un día específico.
        /// </summary>
        /// <param name="userName">Nombre del usuario.</param>
        /// <param name="selectedDate">Fecha a consultar.</param>
        /// <param name="totalCalories">Calorías consumidas.</param>
        /// <param name="totalProtein">Proteínas consumidas.</param>
        /// <param name="totalCarbohydrates">Carbohidratos consumidos.</param>
        /// <param name="totalFat">Grasas consumidas.</param>
        public void CalculateDailyConsumption(
            string userName,
            DateTime selectedDate,
            out double totalCalories,
            out double totalProtein,
            out double totalCarbohydrates,
            out double totalFat)
        {
            totalCalories = 0;
            totalProtein = 0;
            totalCarbohydrates = 0;
            totalFat = 0;

            if (string.IsNullOrWhiteSpace(userName))
            {
                return;
            }

            Menu? dailyMenu = this.menuController.GetMenuByUserAndDate(userName, selectedDate);

            if (dailyMenu == null)
            {
                return;
            }

            this.AddNutritionFromMealText(dailyMenu.Breakfast, ref totalCalories, ref totalProtein, ref totalCarbohydrates, ref totalFat);
            this.AddNutritionFromMealText(dailyMenu.MorningSnack, ref totalCalories, ref totalProtein, ref totalCarbohydrates, ref totalFat);
            this.AddNutritionFromMealText(dailyMenu.Lunch, ref totalCalories, ref totalProtein, ref totalCarbohydrates, ref totalFat);
            this.AddNutritionFromMealText(dailyMenu.AfternoonSnack, ref totalCalories, ref totalProtein, ref totalCarbohydrates, ref totalFat);
            this.AddNutritionFromMealText(dailyMenu.Dinner, ref totalCalories, ref totalProtein, ref totalCarbohydrates, ref totalFat);
        }

        /// <summary>
        /// Calcula la meta diaria de calorías del usuario.
        /// </summary>
        /// <param name="userName">Nombre del usuario.</param>
        /// <returns>Meta diaria de calorías.</returns>
        public double CalculateDailyCalorieGoal(string userName)
        {
            User? user = this.GetUserByUserName(userName);

            if (user == null)
            {
                return 0;
            }

            return this.nutritionInfoController.CalculateMaintenanceCalories(user);
        }

        /// <summary>
        /// Calcula el consumo nutricional total de un período.
        /// </summary>
        /// <param name="userName">Nombre del usuario.</param>
        /// <param name="startDate">Fecha inicial.</param>
        /// <param name="endDate">Fecha final.</param>
        /// <param name="totalCalories">Calorías consumidas en el período.</param>
        /// <param name="totalProtein">Proteínas consumidas en el período.</param>
        /// <param name="totalCarbohydrates">Carbohidratos consumidos en el período.</param>
        /// <param name="totalFat">Grasas consumidas en el período.</param>
        public void CalculateConsumptionByDateRange(
            string userName,
            DateTime startDate,
            DateTime endDate,
            out double totalCalories,
            out double totalProtein,
            out double totalCarbohydrates,
            out double totalFat)
        {
            totalCalories = 0;
            totalProtein = 0;
            totalCarbohydrates = 0;
            totalFat = 0;

            if (string.IsNullOrWhiteSpace(userName))
            {
                return;
            }

            List<Menu> menusInRange = this.GetMenusByDateRange(userName, startDate, endDate);

            foreach (Menu menu in menusInRange)
            {
                this.AddNutritionFromMealText(menu.Breakfast, ref totalCalories, ref totalProtein, ref totalCarbohydrates, ref totalFat);
                this.AddNutritionFromMealText(menu.MorningSnack, ref totalCalories, ref totalProtein, ref totalCarbohydrates, ref totalFat);
                this.AddNutritionFromMealText(menu.Lunch, ref totalCalories, ref totalProtein, ref totalCarbohydrates, ref totalFat);
                this.AddNutritionFromMealText(menu.AfternoonSnack, ref totalCalories, ref totalProtein, ref totalCarbohydrates, ref totalFat);
                this.AddNutritionFromMealText(menu.Dinner, ref totalCalories, ref totalProtein, ref totalCarbohydrates, ref totalFat);
            }
        }

        /// <summary>
        /// Cuenta cuántos días del período cumplieron o superaron la meta calórica.
        /// </summary>
        /// <param name="userName">Nombre del usuario.</param>
        /// <param name="startDate">Fecha inicial.</param>
        /// <param name="endDate">Fecha final.</param>
        /// <returns>Cantidad de días que cumplieron la meta.</returns>
        public int CountDaysMeetingCalorieGoal(string userName, DateTime startDate, DateTime endDate)
        {
            if (string.IsNullOrWhiteSpace(userName))
            {
                return 0;
            }

            double calorieGoal = this.CalculateDailyCalorieGoal(userName);
            List<Menu> menusInRange = this.GetMenusByDateRange(userName, startDate, endDate);
            int daysMeetingGoal = 0;

            foreach (Menu menu in menusInRange)
            {
                this.CalculateDailyConsumption(
                    userName,
                    menu.MenuDate,
                    out double totalCalories,
                    out double totalProtein,
                    out double totalCarbohydrates,
                    out double totalFat);

                if (totalCalories >= calorieGoal)
                {
                    daysMeetingGoal++;
                }
            }

            return daysMeetingGoal;
        }

        /// <summary>
        /// Calcula la meta diaria de macronutrientes del usuario.
        /// </summary>
        /// <param name="userName">Nombre del usuario.</param>
        /// <param name="proteinGoal">Meta de proteínas.</param>
        /// <param name="carbohydratesGoal">Meta de carbohidratos.</param>
        /// <param name="fatGoal">Meta de grasas.</param>
        public void CalculateDailyMacronutrientGoal(
            string userName,
            out double proteinGoal,
            out double carbohydratesGoal,
            out double fatGoal)
        {
            proteinGoal = 0;
            carbohydratesGoal = 0;
            fatGoal = 0;

            User? user = this.GetUserByUserName(userName);

            if (user == null)
            {
                return;
            }

            this.nutritionInfoController.CalculateMacronutrients(
                user,
                out proteinGoal,
                out carbohydratesGoal,
                out fatGoal);
        }

        /// <summary>
        /// Calcula cuántas calorías faltan o sobran respecto a la meta diaria.
        /// </summary>
        /// <param name="userName">Nombre del usuario.</param>
        /// <param name="selectedDate">Fecha a consultar.</param>
        /// <returns>Diferencia entre meta y consumo.</returns>
        public double CalculateRemainingCalories(string userName, DateTime selectedDate)
        {
            double dailyGoal = this.CalculateDailyCalorieGoal(userName);

            this.CalculateDailyConsumption(
                userName,
                selectedDate,
                out double totalCalories,
                out double totalProtein,
                out double totalCarbohydrates,
                out double totalFat);

            return dailyGoal - totalCalories;
        }

        /// <summary>
        /// Calcula cuánto falta o sobra en cada macronutriente respecto a la meta diaria.
        /// </summary>
        /// <param name="userName">Nombre del usuario.</param>
        /// <param name="selectedDate">Fecha a consultar.</param>
        /// <param name="remainingProtein">Diferencia de proteínas.</param>
        /// <param name="remainingCarbohydrates">Diferencia de carbohidratos.</param>
        /// <param name="remainingFat">Diferencia de grasas.</param>
        public void CalculateRemainingMacronutrients(
            string userName,
            DateTime selectedDate,
            out double remainingProtein,
            out double remainingCarbohydrates,
            out double remainingFat)
        {
            remainingProtein = 0;
            remainingCarbohydrates = 0;
            remainingFat = 0;

            this.CalculateDailyMacronutrientGoal(
                userName,
                out double proteinGoal,
                out double carbohydratesGoal,
                out double fatGoal);

            this.CalculateDailyConsumption(
                userName,
                selectedDate,
                out double totalCalories,
                out double totalProtein,
                out double totalCarbohydrates,
                out double totalFat);

            remainingProtein = proteinGoal - totalProtein;
            remainingCarbohydrates = carbohydratesGoal - totalCarbohydrates;
            remainingFat = fatGoal - totalFat;
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
            if (string.IsNullOrWhiteSpace(mealText))
            {
                return;
            }

            string[] mealItems = mealText.Split(new string[] { " | " }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string mealItem in mealItems)
            {
                this.ParseMealItem(mealItem.Trim(), out string foodName, out int quantity);

                Food? matchedFood = this.foodController.GetFoodByName(foodName);

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
    }
}