using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Localization;
using Microsoft.EntityFrameworkCore;
using System.Globalization;
using TaskManagement.Domain.Entities;
using TaskManagement.Infra.Data.Context;
using TaskManagement.Infra.Data.IdentityConfigurations;
using TaskManagement.Infra.IoC;
using TaskManagement.MVC.AutoMapper;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<AppDbContext>(db =>
	db.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"),
	b => b.MigrationsAssembly(typeof(AppDbContext).Assembly.FullName)));

builder.Services.AddDefaultIdentity<User>(options =>
{
	options.User.RequireUniqueEmail = true;
	options.SignIn.RequireConfirmedPhoneNumber = false;
	options.SignIn.RequireConfirmedEmail = false;
	options.SignIn.RequireConfirmedAccount = false;

	options.Password.RequiredLength = 8;
})
	.AddRoles<Role>()
	.AddEntityFrameworkStores<AppDbContext>()
	.AddDefaultTokenProviders()
	.AddErrorDescriber<IdentityLocalization>();

builder.Services.RegisterServices();

builder.Services.AddAutoMapper(typeof(MappingProfile));

builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
	.AddCookie(options =>
	{
		options.Cookie.Name = "TaskManegement.Cookies";
		options.ExpireTimeSpan = TimeSpan.FromMinutes(5);
		options.SlidingExpiration = true;
	});

var app = builder.Build();

app.UseStaticFiles();

app.UseAuthentication();
app.UseAuthorization();

app.UseRouting();

app.MapControllerRoute(
	name: "default",
	pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
