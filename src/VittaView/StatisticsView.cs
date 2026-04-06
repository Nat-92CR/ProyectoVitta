namespace VittaView
{
    using System;
    using System.Globalization;
    using System.Windows.Forms;
    using VittaController.Abstractions;

    /// <summary>
    /// Vista encargada de mostrar las estadísticas nutricionales del usuario.
    /// </summary>
    public partial class StatisticsView : Form
    {
        private readonly IStatisticsController statisticsController;
        private readonly string currentUserName;

        /// <summary>
        /// Inicializa una nueva instancia de la clase StatisticsView.
        /// </summary>
        /// <param name="statisticsController">Controlador de estadísticas.</param>
        /// <param name="currentUserName">Nombre del usuario actual.</param>
        public StatisticsView(IStatisticsController statisticsController, string currentUserName)
        {
            this.InitializeComponent();
            this.statisticsController = statisticsController;
            this.currentUserName = currentUserName;

            this.dtpSelectedDate.Value = DateTime.Today;
            this.dtpStartDate.Value = DateTime.Today.AddDays(-6);
            this.dtpEndDate.Value = DateTime.Today;

            this.LoadStatistics();
        }

        /// <summary>
        /// Carga las estadísticas diarias y por rango de fechas.
        /// </summary>
        private void LoadStatistics()
        {
            if (string.IsNullOrWhiteSpace(this.currentUserName))
            {
                MessageBox.Show("No se pudo identificar el usuario actual.");
                this.Close();
                return;
            }

            DateTime selectedDate = this.dtpSelectedDate.Value.Date;
            DateTime startDate = this.dtpStartDate.Value.Date;
            DateTime endDate = this.dtpEndDate.Value.Date;

            if (startDate > endDate)
            {
                MessageBox.Show("La fecha inicial no puede ser mayor que la fecha final.");
                return;
            }

            this.txtUserName.Text = this.currentUserName;
            this.txtSelectedDate.Text = selectedDate.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);

            string dailySummary = this.LoadDailyStatistics(selectedDate);
            string rangeSummary = this.LoadRangeStatistics(startDate, endDate);

            this.txtDailySummary.Text = dailySummary;
            this.txtPeriodSummary.Text = rangeSummary;
        }

        /// <summary>
        /// Carga las estadísticas nutricionales del día seleccionado.
        /// </summary>
        /// <param name="selectedDate">Fecha seleccionada.</param>
        /// <returns>Resumen diario.</returns>
        private string LoadDailyStatistics(DateTime selectedDate)
        {
            this.statisticsController.CalculateDailyConsumption(
                this.currentUserName,
                selectedDate,
                out double totalCalories,
                out double totalProtein,
                out double totalCarbohydrates,
                out double totalFat);

            double calorieGoal = this.statisticsController.CalculateDailyCalorieGoal(this.currentUserName);

            this.statisticsController.CalculateDailyMacronutrientGoal(
                this.currentUserName,
                out double proteinGoal,
                out double carbohydratesGoal,
                out double fatGoal);

            double remainingCalories = this.statisticsController.CalculateRemainingCalories(this.currentUserName, selectedDate);

            this.statisticsController.CalculateRemainingMacronutrients(
                this.currentUserName,
                selectedDate,
                out double remainingProtein,
                out double remainingCarbohydrates,
                out double remainingFat);

            this.txtConsumedCalories.Text = totalCalories.ToString("0.##", CultureInfo.InvariantCulture);
            this.txtCalorieGoal.Text = calorieGoal.ToString("0.##", CultureInfo.InvariantCulture);
            this.txtRemainingCalories.Text = remainingCalories.ToString("0.##", CultureInfo.InvariantCulture);

            this.txtConsumedProtein.Text = totalProtein.ToString("0.##", CultureInfo.InvariantCulture);
            this.txtProteinGoal.Text = proteinGoal.ToString("0.##", CultureInfo.InvariantCulture);
            this.txtRemainingProtein.Text = remainingProtein.ToString("0.##", CultureInfo.InvariantCulture);

            this.txtConsumedCarbohydrates.Text = totalCarbohydrates.ToString("0.##", CultureInfo.InvariantCulture);
            this.txtCarbohydratesGoal.Text = carbohydratesGoal.ToString("0.##", CultureInfo.InvariantCulture);
            this.txtRemainingCarbohydrates.Text = remainingCarbohydrates.ToString("0.##", CultureInfo.InvariantCulture);

            this.txtConsumedFat.Text = totalFat.ToString("0.##", CultureInfo.InvariantCulture);
            this.txtFatGoal.Text = fatGoal.ToString("0.##", CultureInfo.InvariantCulture);
            this.txtRemainingFat.Text = remainingFat.ToString("0.##", CultureInfo.InvariantCulture);

            return this.BuildDailySummaryMessage(
                remainingCalories,
                remainingProtein,
                remainingCarbohydrates,
                remainingFat);
        }

        /// <summary>
        /// Carga las estadísticas nutricionales del rango seleccionado.
        /// </summary>
        /// <param name="startDate">Fecha inicial.</param>
        /// <param name="endDate">Fecha final.</param>
        /// <returns>Resumen del período.</returns>
        private string LoadRangeStatistics(DateTime startDate, DateTime endDate)
        {
            this.statisticsController.CalculateConsumptionByDateRange(
                this.currentUserName,
                startDate,
                endDate,
                out double totalCalories,
                out double totalProtein,
                out double totalCarbohydrates,
                out double totalFat);

            var menusInRange = this.statisticsController.GetMenusByDateRange(this.currentUserName, startDate, endDate);

            int totalDaysInRange = (endDate - startDate).Days + 1;
            int registeredDays = menusInRange.Count;
            int daysMeetingGoal = this.statisticsController.CountDaysMeetingCalorieGoal(this.currentUserName, startDate, endDate);

            this.txtRangeCalories.Text = totalCalories.ToString("0.##", CultureInfo.InvariantCulture);
            this.txtRangeProtein.Text = totalProtein.ToString("0.##", CultureInfo.InvariantCulture);
            this.txtRangeCarbohydrates.Text = totalCarbohydrates.ToString("0.##", CultureInfo.InvariantCulture);
            this.txtRangeFat.Text = totalFat.ToString("0.##", CultureInfo.InvariantCulture);
            this.txtTotalDaysInRange.Text = totalDaysInRange.ToString(CultureInfo.InvariantCulture);
            this.txtRegisteredDays.Text = registeredDays.ToString(CultureInfo.InvariantCulture);
            this.txtDaysMeetingGoal.Text = daysMeetingGoal.ToString(CultureInfo.InvariantCulture);

            if (registeredDays == 0)
            {
                return "Período consultado: " +
                       startDate.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture) +
                       " a " +
                       endDate.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture) +
                       Environment.NewLine +
                       "No hay menús registrados en ese rango de fechas.";
            }

            double dailyCalorieGoal = this.statisticsController.CalculateDailyCalorieGoal(this.currentUserName);
            double accumulatedGoal = dailyCalorieGoal * registeredDays;
            double periodDifference = accumulatedGoal - totalCalories;
            double averageCaloriesPerRegisteredDay = totalCalories / registeredDays;
            double compliancePercentage = (double)daysMeetingGoal / registeredDays * 100;

            return this.BuildRangeSummaryMessage(
                startDate,
                endDate,
                totalDaysInRange,
                registeredDays,
                daysMeetingGoal,
                totalCalories,
                totalProtein,
                totalCarbohydrates,
                totalFat,
                accumulatedGoal,
                periodDifference,
                averageCaloriesPerRegisteredDay,
                compliancePercentage);
        }

        /// <summary>
        /// Construye el resumen diario.
        /// </summary>
        /// <param name="remainingCalories">Diferencia de calorías.</param>
        /// <param name="remainingProtein">Diferencia de proteínas.</param>
        /// <param name="remainingCarbohydrates">Diferencia de carbohidratos.</param>
        /// <param name="remainingFat">Diferencia de grasas.</param>
        /// <returns>Texto resumen.</returns>
        private string BuildDailySummaryMessage(
            double remainingCalories,
            double remainingProtein,
            double remainingCarbohydrates,
            double remainingFat)
        {
            string caloriesMessage = this.GetDifferenceMessage("calorías", remainingCalories);
            string proteinMessage = this.GetDifferenceMessage("proteínas", remainingProtein);
            string carbohydratesMessage = this.GetDifferenceMessage("carbohidratos", remainingCarbohydrates);
            string fatMessage = this.GetDifferenceMessage("grasas", remainingFat);

            return caloriesMessage + Environment.NewLine +
                   proteinMessage + Environment.NewLine +
                   carbohydratesMessage + Environment.NewLine +
                   fatMessage;
        }

        /// <summary>
        /// Construye el resumen del rango de fechas.
        /// </summary>
        /// <param name="startDate">Fecha inicial.</param>
        /// <param name="endDate">Fecha final.</param>
        /// <param name="totalDaysInRange">Cantidad total de días del rango.</param>
        /// <param name="registeredDays">Cantidad de días con menú registrado.</param>
        /// <param name="daysMeetingGoal">Cantidad de días que cumplieron la meta.</param>
        /// <param name="totalCalories">Calorías del período.</param>
        /// <param name="totalProtein">Proteínas del período.</param>
        /// <param name="totalCarbohydrates">Carbohidratos del período.</param>
        /// <param name="totalFat">Grasas del período.</param>
        /// <param name="accumulatedGoal">Meta acumulada del período con días registrados.</param>
        /// <param name="periodDifference">Diferencia entre meta acumulada y consumo.</param>
        /// <param name="averageCaloriesPerRegisteredDay">Promedio de calorías por día registrado.</param>
        /// <param name="compliancePercentage">Porcentaje de días que cumplieron la meta.</param>
        /// <returns>Texto resumen.</returns>
        private string BuildRangeSummaryMessage(
            DateTime startDate,
            DateTime endDate,
            int totalDaysInRange,
            int registeredDays,
            int daysMeetingGoal,
            double totalCalories,
            double totalProtein,
            double totalCarbohydrates,
            double totalFat,
            double accumulatedGoal,
            double periodDifference,
            double averageCaloriesPerRegisteredDay,
            double compliancePercentage)
        {
            return "Período consultado: " +
                   startDate.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture) +
                   " a " +
                   endDate.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture) +
                   Environment.NewLine +
                   "Se registraron menús en " + registeredDays.ToString(CultureInfo.InvariantCulture) +
                   " de " + totalDaysInRange.ToString(CultureInfo.InvariantCulture) + " días." +
                   Environment.NewLine +
                   "Días que cumplieron la meta calórica: " + daysMeetingGoal.ToString(CultureInfo.InvariantCulture) + "." +
                   Environment.NewLine +
                   "Porcentaje de cumplimiento: " + compliancePercentage.ToString("0.##", CultureInfo.InvariantCulture) + "%." +
                   Environment.NewLine +
                   this.GetPeriodDifferenceMessage(periodDifference) +
                   Environment.NewLine +
                   "Promedio de calorías por día registrado: " + averageCaloriesPerRegisteredDay.ToString("0.##", CultureInfo.InvariantCulture);
        }

        /// <summary>
        /// Genera un mensaje según la diferencia entre meta y consumo.
        /// </summary>
        /// <param name="label">Nombre del dato nutricional.</param>
        /// <param name="difference">Diferencia calculada.</param>
        /// <returns>Texto descriptivo.</returns>
        private string GetDifferenceMessage(string label, double difference)
        {
            if (difference > 0)
            {
                return "Aún faltan " + difference.ToString("0.##", CultureInfo.InvariantCulture) + " de " + label + ".";
            }

            if (difference < 0)
            {
                return "Se excedió la meta por " + Math.Abs(difference).ToString("0.##", CultureInfo.InvariantCulture) + " de " + label + ".";
            }

            return "La meta de " + label + " se cumplió exactamente.";
        }

        /// <summary>
        /// Genera un mensaje para la diferencia del período.
        /// </summary>
        /// <param name="periodDifference">Diferencia calculada del período.</param>
        /// <returns>Texto descriptivo.</returns>
        private string GetPeriodDifferenceMessage(double periodDifference)
        {
            if (periodDifference > 0)
            {
                return "En el período aún faltaron " + periodDifference.ToString("0.##", CultureInfo.InvariantCulture) + " calorías para alcanzar la meta acumulada.";
            }

            if (periodDifference < 0)
            {
                return "En el período se excedió la meta acumulada por " + Math.Abs(periodDifference).ToString("0.##", CultureInfo.InvariantCulture) + " calorías.";
            }

            return "En el período se cumplió exactamente la meta acumulada.";
        }

        /// <summary>
        /// Recarga las estadísticas con las fechas seleccionadas.
        /// </summary>
        private void btnConsult_Click(object sender, EventArgs e)
        {
            this.LoadStatistics();
        }

        /// <summary>
        /// Cierra la vista de estadísticas.
        /// </summary>
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}