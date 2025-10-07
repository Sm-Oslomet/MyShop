using Microsoft.EntityFrameworkCore;
using Myshop.models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews(); // adds services required for handling controllers and views to teh dependency injection container. Setsupp application to use the MVC pattern for handling http requests

builder.Services.AddDbContext<ItemDbContext>(options =>{
    options.UseSqlite(
        builder.Configuration["ConnectionStrings:ItemDbContextConnection"]);
});


var appa = builder.Build();

if (appa.Environment.IsDevelopment())
{
    appa.UseDeveloperExceptionPage();
}

appa.UseStaticFiles();

appa.MapDefaultControllerRoute();

appa.Run();
