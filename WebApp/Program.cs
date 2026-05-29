using Microsoft.EntityFrameworkCore;
using WebApp.Data.Migrations;
using WebApp.Models.Services;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
//Agregar contexto de la base de datos como un servicio
builder.Services.AddDbContext<AppDBContext>(
    options => options.UseSqlServer(builder.Configuration.GetConnectionString("Conexion")));
   

builder.Services.AddTransient<IProyectoresService, ProyectoresService>();



var app = builder.Build();




// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();


app.Run();
