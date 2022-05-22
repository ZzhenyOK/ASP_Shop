using ASP_Shop.Data;
using ASP_Shop.Data.Interfaces;
using ASP_Shop.Data.Mocks;
using ASP_Shop.Data.Repository;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddMvc();
builder.Services.AddControllers();
builder.Services.AddTransient<ICars, MockCars>();
builder.Services.AddTransient<ICarsCategory, MockCategory>();

var app = builder.Build();

app.UseDeveloperExceptionPage();
app.UseStaticFiles();
app.UseStatusCodePages();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Cars}/{Action=List}/{id?}");

app.MapGet("/", () => "Hello World!");

app.Run();
