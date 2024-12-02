using Microsoft.EntityFrameworkCore;
using PLANCAR_DAO.DAO;
using PLANCAR_DAO.Data;
using PLANCAR_DAO.IDAO;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<PlancarDbContext>(options =>
    options.UseOracle("User Id=Test;Password=password;Data Source=localhost:1521/free"));

builder.Services.AddScoped<IDepartementDAO, DepartementEF_DAO>();

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
