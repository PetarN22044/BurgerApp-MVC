using BurgerApp;
using BurgerApp.Services.Interfaces;
using BurgerApp.Services.Services;
using BurgerApp.Data.DataRepositories;
using BurgerApp.Data.Repository;
// ...

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// Register your services
builder.Services.AddScoped<IBurgerService, BurgerService>();
builder.Services.AddScoped<IBurgerRepository, BurgerRepository>();
builder.Services.AddScoped<IOrderService,OrderService>();
builder.Services.AddScoped<IOrderRepository, OrderRepository>();

// ...

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
