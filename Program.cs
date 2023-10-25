var builder = WebApplication.CreateBuilder(args);
// Indicarle al servidor que utilizaremos la arquitectura de MVC
builder.Services.AddControllersWithViews();
var app = builder.Build();

// Configuracion para utilizar: 
// - rutas, 
app.UseStaticFiles();
// - archivos estaticos 
app.UseRouting();
// - y autentificacion
app.UseAuthorization();

// Asignación a nuestro Controlador
app.MapControllerRoute(    
    name: "default",    
    pattern: "{controller=Home}/{action=Index}/{id?}");


app.Run();
