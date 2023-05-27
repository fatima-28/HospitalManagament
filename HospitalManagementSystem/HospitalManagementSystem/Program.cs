using HospitalManagementSystem.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using HospitalManagementSystem.Utilities;
using HospitalManagementSystem.Repositories.Implementations;
using HospitalManagementSystem.Repositories.Interfaces;
using Microsoft.AspNetCore.Identity.UI.Services;
using HospitalManagementSystem.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddIdentity<IdentityUser,IdentityRole>()
    .AddEntityFrameworkStores<AppDbContext>();

builder.Services.AddScoped<IDbInitalizer, DbInitalizer>();
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddScoped<IEmailSender, EmailSender>();
builder.Services.AddTransient<IHospitalService, HospitalService>();
builder.Services.AddTransient<IRoomService, RoomService>();
builder.Services.AddTransient<IContactService, ContactService>();
builder.Services.AddRazorPages();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();
DataSeeding();
app.UseRouting();
app.UseAuthentication();;

app.UseAuthorization();
app.MapRazorPages();
app.MapControllerRoute(
    name: "default",
    pattern: "{Area=AdminPanel}/{controller=Hospital}/{action=Index}/{id?}");

app.Run();
void DataSeeding()
{
    using (var scope = app.Services.CreateScope())
    {
        var dbInitalizer=scope.ServiceProvider.GetRequiredService<IDbInitalizer>();
        dbInitalizer.Initialize();
    }

}