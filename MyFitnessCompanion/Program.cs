using Microsoft.AspNetCore.Identity;
using MyFitnessCompanion.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Diagnostics;
using MyFitnessCompanion.Areas.Identity.Data;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("MyFitnessCompanionDbContextConnection") ?? throw new InvalidOperationException("Connection string 'MyFitnessCompanionDbContextConnection' not found.");

builder.Services.AddDbContext<MyFitnessCompanionDbContext>(options => options.UseSqlServer(connectionString));

builder.Services.AddDefaultIdentity<MyFitnessCompanionUser>(options => options.SignIn.RequireConfirmedAccount = false).AddEntityFrameworkStores<MyFitnessCompanionDbContext>();
// Add services to the container.

builder.Services.AddControllersWithViews();

builder.Services.AddRazorPages();

// Configure the HTTP request pipeline.
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

app.MapRazorPages();

app.Run();
