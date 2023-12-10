using Microsoft.EntityFrameworkCore;
using TaskManagement.Infra.Data.Context;
using TaskManagement.Infra.IoC;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<AppDbContext>(db =>
	db.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"),
	b => b.MigrationsAssembly(typeof(AppDbContext).Assembly.FullName)));

builder.Services.RegisterServices();

var app = builder.Build();

app.UseStaticFiles();

app.UseRouting();

app.MapControllerRoute(
	name: "default",
	pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
