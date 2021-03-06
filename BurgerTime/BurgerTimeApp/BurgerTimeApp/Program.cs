using BurgerTimeApp.DataAccsess.Database.Context;
using BurgerTimeApp.DataAccsess.Repository;
using BurgerTimeApp.Domain.Repositories;
using BurgerTimeApp.Services.Service;
using BurgerTimeApp.ViewModels.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllersWithViews();
string databaseConnectionString = builder.Configuration.GetConnectionString("DevConnection");
builder.Services.AddScoped<IOrderService, OrderService>() 
                .AddScoped<IOrderRepository, OrderRepository>()
                .AddScoped<IBurgerService, BurgerService>()
                .AddScoped<IBurgerRepository, BurgerRepository>()
                .AddDbContext<BurgerDbContext>(options =>
                {
                    options.UseSqlServer(databaseConnectionString); 
                })
                .AddScoped<IBurgerDbContext, BurgerDbContext>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
