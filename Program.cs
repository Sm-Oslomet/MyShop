using Microsoft.EntityFrameworkCore;
using MyShop.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews(); // adds services required for handling controllers and views to teh dependency injection container. Setsupp application to use the MVC pattern for handling http requests

builder.Services.AddDbContext<ItemDbContext>(options =>{
    options.UseSqlite(
        builder.Configuration["ConnectionStrings:ItemDbContextConnection"]);
});


var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
    DBInit.Seed(app);
}

app.UseStaticFiles();

app.MapDefaultControllerRoute();

app.Run();
