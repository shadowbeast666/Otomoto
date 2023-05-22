using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;
using UserManagement.MVC.Models;
using Otomoto.Models;

namespace Otomoto.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Car> Cars { get; set; }

        public DbSet<CarBrand> CarBrands { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.HasDefaultSchema("Identity");
            builder.Entity<ApplicationUser>(entity =>
            {
                entity.ToTable(name: "User");
            });

            builder.Entity<IdentityRole>(entity =>
            {
                entity.ToTable(name: "Role");
            });
            builder.Entity<IdentityUserRole<string>>(entity =>
            {
                entity.ToTable("UserRoles");
            });

            builder.Entity<IdentityUserClaim<string>>(entity =>
            {
                entity.ToTable("UserClaims");
            });

            builder.Entity<IdentityUserLogin<string>>(entity =>
            {
                entity.ToTable("UserLogins");
            });

            builder.Entity<IdentityRoleClaim<string>>(entity =>
            {
                entity.ToTable("RoleClaims");

            });

            builder.Entity<IdentityUserToken<string>>(entity =>
            {
                entity.ToTable("UserTokens");
            });

            builder.Entity<Car>().HasKey(c => c.CarId);
            builder.Entity<Car>().Property(c => c.Opis).IsRequired();
            builder.Entity<Car>().Property(c => c.Marka).IsRequired();
            builder.Entity<Car>().Property(c => c.Model).IsRequired();
            builder.Entity<Car>().Property(c => c.Typ).IsRequired();
            builder.Entity<Car>().Property(c => c.Pojemnosc).IsRequired();
            builder.Entity<Car>().Property(c => c.SkrzyniaBiegow).IsRequired();
            builder.Entity<Car>().Property(c => c.RokProdukcji).IsRequired();
            builder.Entity<Car>().Property(c => c.Cena).IsRequired();
            builder.Entity<Car>().Property(c => c.Vin);
            builder.Entity<Car>().Property(c => c.Przebieg).IsRequired();
            builder.Entity<Car>().Property(c => c.RodzajPaliwa).IsRequired();
            builder.Entity<Car>().Property(c => c.CarPicture).HasColumnType("varbinary(max)");


            builder.Entity<Car>().HasData(
            new Car
            {
                CarId = 1,
                Opis = "Opis1",
                Marka = "BMW",
                Model = "Model1",
                Typ = "Typ1",
                Pojemnosc = "Pojemnosc1",
                SkrzyniaBiegow = "SkrzyniaBiegow1",
                RokProdukcji = 2000,
                Cena = 10000,
                Vin = 123456,
                Przebieg = 10000,
                RodzajPaliwa = "RodzajPaliwa1",
                CreatedAt = DateTime.Now,
                IsAdActive = true,
                IsAdPaid = false
                //CarPicture = null because we're not seeding any pictures
            },
            new Car
            {
                CarId = 2,
                Opis = "Excellent condition, well maintained",
                Marka = "Toyota",
                Model = "Corolla",
                Typ = "Sedan",
                Pojemnosc = "1.8L",
                SkrzyniaBiegow = "Automatic",
                RokProdukcji = 2009,
                Cena = 20000,
                Vin = 100001,
                Przebieg = 50000,
                RodzajPaliwa = "Petrol",
                CreatedAt = DateTime.Now,
                IsAdActive = true,
                IsAdPaid = true
            },
            new Car
            {
                CarId = 3,
                Opis = "Low mileage, good fuel efficiency",
                Marka = "Honda",
                Model = "Civic",
                Typ = "Hatchback",
                Pojemnosc = "2.0L",
                SkrzyniaBiegow = "Manual",
                RokProdukcji = 2023,
                Cena = 18000,
                Vin = 100002,
                Przebieg = 30000,
                RodzajPaliwa = "Petrol",
                CreatedAt = DateTime.Now,
                IsAdActive = true,
                IsAdPaid = false
            },
             new Car
             {
                 CarId = 4,
                 Opis = "Elegant and comfortable family car",
                 Marka = "Toyota",
                 Model = "Camry",
                 Typ = "Sedan",
                 Pojemnosc = "2500cc",
                 SkrzyniaBiegow = "Automatic",
                 RokProdukcji = 2021,
                 Cena = 30000,
                 Vin = 123456789,
                 Przebieg = 0,
                 RodzajPaliwa = "Petrol",
                 CreatedAt = DateTime.Now,
                 IsAdActive = true,
                 IsAdPaid = false
                 //CarPicture = null because we're not seeding any pictures
             },
            new Car
            {
                CarId = 5,
                Opis = "Sporty, compact and fun to drive",
                Marka = "Honda",
                Model = "Civic",
                Typ = "Hatchback",
                Pojemnosc = "1800cc",
                SkrzyniaBiegow = "Manual",
                RokProdukcji = 1998,
                Cena = 20000,
                Vin = 223456789,
                Przebieg = 0,
                RodzajPaliwa = "Petrol",
                CreatedAt = DateTime.Now,
                IsAdActive = true,
                IsAdPaid = false
                //CarPicture = null because we're not seeding any pictures
            }
            );
        }
    }
}


