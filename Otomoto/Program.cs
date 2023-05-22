using Microsoft.AspNetCore.Antiforgery;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Otomoto.Data;
using Otomoto.Models;
using UserManagement.MVC.Data;
using UserManagement.MVC.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddDefaultIdentity<ApplicationUser>(options =>
{
    options.SignIn.RequireConfirmedAccount = true;
    // Configuration options for authentication
})
    .AddRoles<IdentityRole>()
    .AddEntityFrameworkStores<ApplicationDbContext>();

builder.Services.Configure<IdentityOptions>(options =>
{
    options.Password.RequireDigit = true;
    options.Password.RequiredLength = 8;
    // Other password options

    // Account lockout options
    options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(15);
    options.Lockout.MaxFailedAccessAttempts = 5;
    options.Lockout.AllowedForNewUsers = true;

    // Account confirmation options
    options.SignIn.RequireConfirmedEmail = true;
    options.SignIn.RequireConfirmedPhoneNumber = false;

    // Authorization options
    options.ClaimsIdentity.RoleClaimType = "Role";
    options.ClaimsIdentity.UserIdClaimType = "UserId";
    options.ClaimsIdentity.UserNameClaimType = "UserName";
});



var app = builder.Build();

app.UseStaticFiles();
app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();



app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.UseEndpoints(endpoints =>
{
    
    endpoints.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}");


    endpoints.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}");
    endpoints.MapRazorPages();
});

// Apply database migration and seed data
await EnsureDatabaseUpdated(app);

app.Run();

async Task EnsureDatabaseUpdated(WebApplication app)
{
    using var scope = app.Services.CreateScope();
    var services = scope.ServiceProvider;
    var loggerFactory = services.GetRequiredService<ILoggerFactory>();
    try
    {
        var context = services.GetRequiredService<ApplicationDbContext>();
        var userManager = services.GetRequiredService<UserManager<ApplicationUser>>();
        var roleManager = services.GetRequiredService<RoleManager<IdentityRole>>();
        await context.Database.MigrateAsync();
        await ContextSeed.SeedRolesAsync(userManager, roleManager);
        await ContextSeed.SeedSuperAdminAsync(userManager, roleManager);

        if (!context.CarBrands.Any())
        {
            // Add car brands to the database
            var carBrands = new List<CarBrand>
            {
                new CarBrand { Name = "Abarth" },
                new CarBrand { Name = "Acura" },
                new CarBrand { Name = "Alfa Romeo" },
                new CarBrand { Name = "Aston Martin" },
                new CarBrand { Name = "Audi" },
                new CarBrand { Name = "Bentley" },
                new CarBrand { Name = "BMW" },
                new CarBrand { Name = "Bugatti" },
                new CarBrand { Name = "Buick" },
                new CarBrand { Name = "Cadillac" },
                new CarBrand { Name = "Chevrolet" },
                new CarBrand { Name = "Chrysler" },
                new CarBrand { Name = "Citroën" },
                new CarBrand { Name = "Datsun" },
                new CarBrand { Name = "Dodge" },
                new CarBrand { Name = "Ferrari" },
                new CarBrand { Name = "Fiat" },
                new CarBrand { Name = "Ford" },
                new CarBrand { Name = "Genesis" },
                new CarBrand { Name = "GMC" },
                new CarBrand { Name = "Honda" },
                new CarBrand { Name = "Hummer" },
                new CarBrand { Name = "Hyundai" },
                new CarBrand { Name = "Infiniti" },
                new CarBrand { Name = "Isuzu" },
                new CarBrand { Name = "Jaguar" },
                new CarBrand { Name = "Jeep" },
                new CarBrand { Name = "Kia" },
                new CarBrand { Name = "Lamborghini" },
                new CarBrand { Name = "Lancia" },
                new CarBrand { Name = "Land Rover" },
                new CarBrand { Name = "Lexus" },
                new CarBrand { Name = "Lincoln" },
                new CarBrand { Name = "Lotus" },
                new CarBrand { Name = "Maserati" },
                new CarBrand { Name = "Mazda" },
                new CarBrand { Name = "McLaren" },
                new CarBrand { Name = "Mercedes-Benz" },
                new CarBrand { Name = "Mercury" },
                new CarBrand { Name = "Mini" },
                new CarBrand { Name = "Mitsubishi" },
                new CarBrand { Name = "Nissan" },
                new CarBrand { Name = "Pontiac" },
                new CarBrand { Name = "Porsche" },
                new CarBrand { Name = "Ram" },
                new CarBrand { Name = "Rolls-Royce" },
                new CarBrand { Name = "Saab" },
                new CarBrand { Name = "Saturn" },
                new CarBrand { Name = "Scion" },
                new CarBrand { Name = "Smart" },
                new CarBrand { Name = "Subaru" },
                new CarBrand { Name = "Suzuki" },
                new CarBrand { Name = "Tesla" },
                new CarBrand { Name = "Toyota" },
                new CarBrand { Name = "Volkswagen" },
                new CarBrand { Name = "Volvo" }
                    };

            await context.CarBrands.AddRangeAsync(carBrands);
            await context.SaveChangesAsync();
        }
        
    }
    catch (Exception ex)
    {
        var logger = loggerFactory.CreateLogger<Program>();
        logger.LogError(ex, "An error occurred seeding the DB.");
    }
}
