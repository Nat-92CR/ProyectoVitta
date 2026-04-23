using VittaBlazor.Components;
using VittaController;
using VittaController.Abstractions;
using VittaModel;

// Se crea el builder de la aplicación web.
var builder = WebApplication.CreateBuilder(args);

// Se agregan los componentes de Razor con renderizado interactivo del lado del servidor.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

// Se definen las rutas de los archivos CSV utilizados por la aplicación.
string usersPath = Path.GetFullPath(
    Path.Combine(builder.Environment.ContentRootPath, "..", "..", "data", "users.csv"));

string foodsPath = Path.GetFullPath(
    Path.Combine(builder.Environment.ContentRootPath, "..", "..", "data", "foods.csv"));

string menusPath = Path.GetFullPath(
    Path.Combine(builder.Environment.ContentRootPath, "..", "..", "data", "menus.csv"));

// Se registra el controlador de usuarios como servicio inyectable.
builder.Services.AddScoped<UserController>(_ =>
{
    var fileHandler = new FileHandler<User>(usersPath);
    return new UserController(fileHandler);
});

// Se registra el controlador de inicio de sesión, que depende del controlador de usuarios.
builder.Services.AddScoped<LoginController>(sp =>
{
    var userController = sp.GetRequiredService<UserController>();
    return new LoginController(userController);
});

// Se registra el controlador de alimentos.
builder.Services.AddScoped<IFoodController>(_ =>
{
    var fileHandler = new FileHandler<Food>(foodsPath);
    return new FoodController(fileHandler);
});

// Se registra el controlador de menús.
builder.Services.AddScoped<IMenuController>(_ =>
{
    var fileHandler = new FileHandler<Menu>(menusPath);
    return new MenuController(fileHandler);
});

// Se registra el controlador de información nutricional, que depende del controlador de inicio de sesión.
builder.Services.AddScoped<INutritionInfoController>(sp =>
{
    var loginController = sp.GetRequiredService<LoginController>();
    return new NutritionInfoController(loginController);
});

// Se registra el controlador de estadísticas nutricionales, que depende de los controladores de
// inicio de sesión, alimentos, menús e información nutricional.
builder.Services.AddScoped<IStatisticsController>(sp =>
{
    var loginController = sp.GetRequiredService<LoginController>();
    var foodController = sp.GetRequiredService<IFoodController>();
    var menuController = sp.GetRequiredService<IMenuController>();
    var nutritionInfoController = sp.GetRequiredService<INutritionInfoController>();
    return new StatisticsController(loginController, foodController, menuController, nutritionInfoController);
});

// Se construye la aplicación una vez configurados todos los servicios.
var app = builder.Build();

// Se configura el manejo de errores para ambientes distintos al de desarrollo.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseAntiforgery();

app.MapStaticAssets();
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();