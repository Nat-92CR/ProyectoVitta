namespace VittaController
{
    using System;
    using System.Collections.Generic;
    using System.Text;
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
            List<Menu> menusInRange = new List<Menu>();

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
        /// Exporta un resumen estadístico del usuario en formato CSV.
        /// </summary>
        /// <param name="userName">Nombre del usuario.</param>
        /// <param name="startDate">Fecha inicial.</param>
        /// <param name="endDate">Fecha final.</param>
        /// <returns>Contenido CSV del resumen.</returns>
        public string ExportSummaryToCsv(string userName, DateTime startDate, DateTime endDate)
        {
            this.CalculateConsumptionByDateRange(
                userName,
                startDate,
                endDate,
                out double totalCalories,
                out double totalProtein,
                out double totalCarbohydrates,
                out double totalFat);

            double calorieGoal = this.CalculateDailyCalorieGoal(userName);

            this.CalculateDailyMacronutrientGoal(
                userName,
                out double proteinGoal,
                out double carbohydratesGoal,
                out double fatGoal);

            int daysMeetingGoal = this.CountDaysMeetingCalorieGoal(userName, startDate, endDate);

            StringBuilder csv = new StringBuilder();

            csv.AppendLine("Campo,Valor");
            csv.AppendLine("Usuario," + userName);
            csv.AppendLine("Fecha inicial," + startDate.ToString("dd/MM/yyyy"));
            csv.AppendLine("Fecha final," + endDate.ToString("dd/MM/yyyy"));
            csv.AppendLine("Calorías consumidas," + totalCalories.ToString("0.##"));
            csv.AppendLine("Proteínas consumidas," + totalProtein.ToString("0.##"));
            csv.AppendLine("Carbohidratos consumidos," + totalCarbohydrates.ToString("0.##"));
            csv.AppendLine("Grasas consumidas," + totalFat.ToString("0.##"));
            csv.AppendLine("Meta calórica diaria," + calorieGoal.ToString("0.##"));
            csv.AppendLine("Meta proteína," + proteinGoal.ToString("0.##"));
            csv.AppendLine("Meta carbohidratos," + carbohydratesGoal.ToString("0.##"));
            csv.AppendLine("Meta grasas," + fatGoal.ToString("0.##"));
            csv.AppendLine("Días que cumplieron meta calórica," + daysMeetingGoal);

            return csv.ToString();
        }

        /// <summary>
        /// Exporta un resumen estadístico del usuario en formato HTML.
        /// </summary>
        /// <param name="userName">Nombre del usuario.</param>
        /// <param name="startDate">Fecha inicial.</param>
        /// <param name="endDate">Fecha final.</param>
        /// <returns>Contenido HTML del resumen.</returns>
        public string ExportSummaryToHtml(string userName, DateTime startDate, DateTime endDate)
        {
            this.CalculateConsumptionByDateRange(
                userName,
                startDate,
                endDate,
                out double totalCalories,
                out double totalProtein,
                out double totalCarbohydrates,
                out double totalFat);

            double calorieGoal = this.CalculateDailyCalorieGoal(userName);

            this.CalculateDailyMacronutrientGoal(
                userName,
                out double proteinGoal,
                out double carbohydratesGoal,
                out double fatGoal);

            int daysMeetingGoal = this.CountDaysMeetingCalorieGoal(userName, startDate, endDate);

            StringBuilder html = new StringBuilder();

            html.AppendLine("<html>");
            html.AppendLine("<head><title>Resumen estadístico</title></head>");
            html.AppendLine("<body>");
            html.AppendLine("<h1>Resumen estadístico</h1>");
            html.AppendLine("<table border='1' cellpadding='6' cellspacing='0'>");
            html.AppendLine("<tr><th>Campo</th><th>Valor</th></tr>");
            html.AppendLine("<tr><td>Usuario</td><td>" + userName + "</td></tr>");
            html.AppendLine("<tr><td>Fecha inicial</td><td>" + startDate.ToString("dd/MM/yyyy") + "</td></tr>");
            html.AppendLine("<tr><td>Fecha final</td><td>" + endDate.ToString("dd/MM/yyyy") + "</td></tr>");
            html.AppendLine("<tr><td>Calorías consumidas</td><td>" + totalCalories.ToString("0.##") + "</td></tr>");
            html.AppendLine("<tr><td>Proteínas consumidas</td><td>" + totalProtein.ToString("0.##") + "</td></tr>");
            html.AppendLine("<tr><td>Carbohidratos consumidos</td><td>" + totalCarbohydrates.ToString("0.##") + "</td></tr>");
            html.AppendLine("<tr><td>Grasas consumidas</td><td>" + totalFat.ToString("0.##") + "</td></tr>");
            html.AppendLine("<tr><td>Meta calórica diaria</td><td>" + calorieGoal.ToString("0.##") + "</td></tr>");
            html.AppendLine("<tr><td>Meta proteína</td><td>" + proteinGoal.ToString("0.##") + "</td></tr>");
            html.AppendLine("<tr><td>Meta carbohidratos</td><td>" + carbohydratesGoal.ToString("0.##") + "</td></tr>");
            html.AppendLine("<tr><td>Meta grasas</td><td>" + fatGoal.ToString("0.##") + "</td></tr>");
            html.AppendLine("<tr><td>Días que cumplieron meta calórica</td><td>" + daysMeetingGoal + "</td></tr>");
            html.AppendLine("</table>");
            html.AppendLine("</body>");
            html.AppendLine("</html>");

            return html.ToString();
        }

        /// <summary>
        /// Obtiene el producto más consumido entre todos los usuarios en un rango de fechas.
        /// </summary>
        /// <param name="users">Lista de usuarios.</param>
        /// <param name="startDate">Fecha inicial.</param>
        /// <param name="endDate">Fecha final.</param>
        /// <param name="productName">Nombre del producto más consumido.</param>
        /// <param name="totalQuantity">Cantidad total consumida.</param>
        public void GetMostConsumedProduct(
            List<User> users,
            DateTime startDate,
            DateTime endDate,
            out string productName,
            out int totalQuantity)
        {
            productName = "No disponible";
            totalQuantity = 0;

            if (users == null || users.Count == 0)
            {
                return;
            }

            Dictionary<string, int> productCounters = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);

            foreach (User user in users)
            {
                if (user == null || string.IsNullOrWhiteSpace(user.UserName))
                {
                    continue;
                }

                List<Menu> menus = this.GetMenusByDateRange(user.UserName, startDate, endDate);

                foreach (Menu menu in menus)
                {
                    this.AddMealItemsToCounter(menu.Breakfast, productCounters);
                    this.AddMealItemsToCounter(menu.MorningSnack, productCounters);
                    this.AddMealItemsToCounter(menu.Lunch, productCounters);
                    this.AddMealItemsToCounter(menu.AfternoonSnack, productCounters);
                    this.AddMealItemsToCounter(menu.Dinner, productCounters);
                }
            }

            foreach (KeyValuePair<string, int> item in productCounters)
            {
                if (item.Value > totalQuantity)
                {
                    productName = item.Key;
                    totalQuantity = item.Value;
                }
            }
        }

        /// <summary>
        /// Calcula los porcentajes de tipos de dieta de todos los usuarios.
        /// </summary>
        /// <param name="users">Lista de usuarios.</param>
        /// <returns>Diccionario con dieta y porcentaje.</returns>
        public Dictionary<string, double> GetDietTypePercentages(List<User> users)
        {
            Dictionary<string, double> result = new Dictionary<string, double>();

            if (users == null || users.Count == 0)
            {
                return result;
            }

            Dictionary<string, int> counters = new Dictionary<string, int>();
            int totalUsers = 0;

            foreach (User user in users)
            {
                if (user == null)
                {
                    continue;
                }

                string dietType = string.IsNullOrWhiteSpace(user.DietType)
                    ? "No especificado"
                    : user.DietType.Trim();

                if (!counters.ContainsKey(dietType))
                {
                    counters[dietType] = 0;
                }

                counters[dietType]++;
                totalUsers++;
            }

            if (totalUsers == 0)
            {
                return result;
            }

            foreach (KeyValuePair<string, int> item in counters)
            {
                result[item.Key] = (item.Value * 100.0) / totalUsers;
            }

            return result;
        }

        /// <summary>
        /// Obtiene el ranking de usuarios con más menús ingresados en un rango de fechas.
        /// </summary>
        /// <param name="users">Lista de usuarios.</param>
        /// <param name="startDate">Fecha inicial.</param>
        /// <param name="endDate">Fecha final.</param>
        /// <returns>Lista ordenada de usuarios y cantidad de menús.</returns>
        public List<KeyValuePair<string, int>> GetUsersWithMostMenus(
            List<User> users,
            DateTime startDate,
            DateTime endDate)
        {
            List<KeyValuePair<string, int>> result = new List<KeyValuePair<string, int>>();

            if (users == null || users.Count == 0)
            {
                return result;
            }

            foreach (User user in users)
            {
                if (user == null || string.IsNullOrWhiteSpace(user.UserName))
                {
                    continue;
                }

                int menuCount = this.GetMenusByDateRange(user.UserName, startDate, endDate).Count;

                if (menuCount > 0)
                {
                    result.Add(new KeyValuePair<string, int>(user.UserName, menuCount));
                }
            }

            result.Sort((first, second) =>
            {
                int compareByCount = second.Value.CompareTo(first.Value);

                if (compareByCount != 0)
                {
                    return compareByCount;
                }

                return string.Compare(first.Key, second.Key, StringComparison.OrdinalIgnoreCase);
            });

            return result;
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
        /// Acumula la cantidad de productos encontrados en el texto de un tiempo de comida.
        /// </summary>
        /// <param name="mealText">Texto del tiempo de comida.</param>
        /// <param name="productCounters">Diccionario acumulador de cantidades.</param>
        private void AddMealItemsToCounter(string mealText, Dictionary<string, int> productCounters)
        {
            if (string.IsNullOrWhiteSpace(mealText))
            {
                return;
            }

            string[] mealItems = mealText.Split(new string[] { " | " }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string mealItem in mealItems)
            {
                this.ParseMealItem(mealItem.Trim(), out string foodName, out int quantity);

                if (string.IsNullOrWhiteSpace(foodName))
                {
                    continue;
                }

                if (!productCounters.ContainsKey(foodName))
                {
                    productCounters[foodName] = 0;
                }

                productCounters[foodName] += quantity;
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