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
            builder.Entity<Car>().Property(c => c.CarUserId);



            builder.Entity<Car>().HasData(
            new Car
            {
                CarId = 1,
                Opis = "Spacious interior, excellent safety features",
                Marka = "Toyota",
                Model = "Camry",
                Typ = "Sedan",
                Pojemnosc = "2.5L",
                SkrzyniaBiegow = "Automatic",
                RokProdukcji = 2022,
                Cena = 25000,
                Vin = 100003,
                Przebieg = 15000,
                RodzajPaliwa = "Petrol",
                CreatedAt = DateTime.Now,
                IsAdActive = true,
                IsAdPaid = true,
                CarUserId = "5"
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
                IsAdPaid = true,
                 CarUserId = "2"
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
                IsAdPaid = false,
                 CarUserId = "3"
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
                 IsAdPaid = false,
                  CarUserId = "4"
                 
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
                IsAdPaid = false,
                CarUserId = "5"
               
            },
            new Car
            {
                CarId = 6,
                Opis = "Luxurious interior, advanced technology",
                Marka = "Mercedes-Benz",
                Model = "E-Class",
                Typ = "Sedan",
                Pojemnosc = "3.0L",
                SkrzyniaBiegow = "Automatic",
                RokProdukcji = 2021,
                Cena = 45000,
                Vin = 100004,
                Przebieg = 20000,
                RodzajPaliwa = "Diesel",
                CreatedAt = DateTime.Now,
                IsAdActive = true,
                IsAdPaid = true,
                CarUserId = "8"
            },
            new Car
            {
                CarId = 7,
                Opis = "Powerful engine, sporty design",
                Marka = "BMW",
                Model = "M3",
                Typ = "Sedan",
                Pojemnosc = "3.0L",
                SkrzyniaBiegow = "Automatic",
                RokProdukcji = 2023,
                Cena = 60000,
                Vin = 100006,
                Przebieg = 1000,
                RodzajPaliwa = "Petrol",
                CreatedAt = DateTime.Now,
                IsAdActive = true,
                IsAdPaid = true,
                CarUserId = "7"
            },
            new Car 
            {
                CarId = 8,
                Opis = "Family-friendly, spacious seating",
                Marka = "Volkswagen",
                Model = "Tiguan",
                Typ = "SUV",
                Pojemnosc = "2.0L",
                SkrzyniaBiegow = "Automatic",
                RokProdukcji = 2022,
                Cena = 28000,
                Vin = 100007,
                Przebieg = 12000,
                RodzajPaliwa = "Petrol",
                CreatedAt = DateTime.Now,
                IsAdActive = true,
                IsAdPaid = true,
                CarUserId = "4"
            },
            new Car
            {
                CarId = 9,
                Opis = "Compact and agile city car",
                Marka = "Fiat",
                Model = "500",
                Typ = "Hatchback",
                Pojemnosc = "1.2L",
                SkrzyniaBiegow = "Manual",
                RokProdukcji = 2023,
                Cena = 15000,
                Vin = 100008,
                Przebieg = 5000,
                RodzajPaliwa = "Petrol",
                CreatedAt = DateTime.Now,
                IsAdActive = true,
                IsAdPaid = false,
                CarUserId = "6"
            },
            new Car
            {
                CarId = 10,
                Opis = "Efficient hybrid with modern features",
                Marka = "Toyota",
                Model = "Prius",
                Typ = "Sedan",
                Pojemnosc = "1.8L",
                SkrzyniaBiegow = "Automatic",
                RokProdukcji = 2022,
                Cena = 22000,
                Vin = 100009,
                Przebieg = 8000,
                RodzajPaliwa = "Hybrid",
                CreatedAt = DateTime.Now,
                IsAdActive = true,
                IsAdPaid = true,
                CarUserId = "9"
            },
            new Car
            {
                CarId = 11,
                Opis = "Powerful performance and luxury",
                Marka = "Mercedes-Benz",
                Model = "C-Class",
                Typ = "Sedan",
                Pojemnosc = "2.0L",
                SkrzyniaBiegow = "Automatic",
                RokProdukcji = 2022,
                Cena = 45000,
                Vin = 100010,
                Przebieg = 10000,
                RodzajPaliwa = "Petrol",
                CreatedAt = DateTime.Now,
                IsAdActive = true,
                IsAdPaid = true,
                CarUserId = "7"
            },
            new Car
            {
                CarId = 12,
                Opis = "Spacious and comfortable SUV",
                Marka = "Volvo",
                Model = "XC60",
                Typ = "SUV",
                Pojemnosc = "2.0L",
                SkrzyniaBiegow = "Automatic",
                RokProdukcji = 2023,
                Cena = 38000,
                Vin = 100011,
                Przebieg = 5000,
                RodzajPaliwa = "Diesel",
                CreatedAt = DateTime.Now,
                IsAdActive = true,
                IsAdPaid = true,
                CarUserId = "5"
            },
            new Car
            {
                CarId = 13,
                Opis = "Sporty and stylish coupe",
                Marka = "BMW",
                Model = "4 Series",
                Typ = "Coupe",
                Pojemnosc = "3.0L",
                SkrzyniaBiegow = "Automatic",
                RokProdukcji = 2022,
                Cena = 55000,
                Vin = 100012,
                Przebieg = 8000,
                RodzajPaliwa = "Petrol",
                CreatedAt = DateTime.Now,
                IsAdActive = true,
                IsAdPaid = true,
                CarUserId = "8"
            },
            new Car
            {
                CarId = 14,
                Opis = "Versatile and capable off-road SUV",
                Marka = "Jeep",
                Model = "Wrangler",
                Typ = "SUV",
                Pojemnosc = "3.6L",
                SkrzyniaBiegow = "Manual",
                RokProdukcji = 2023,
                Cena = 42000,
                Vin = 100013,
                Przebieg = 500,
                RodzajPaliwa = "Petrol",
                CreatedAt = DateTime.Now,
                IsAdActive = true,
                IsAdPaid = true,
                CarUserId = "10"
            },
            new Car
            {
                CarId = 15,
                Opis = "Elegant and luxurious sedan",
                Marka = "Audi",
                Model = "A6",
                Typ = "Sedan",
                Pojemnosc = "2.0L",
                SkrzyniaBiegow = "Automatic",
                RokProdukcji = 2023,
                Cena = 50000,
                Vin = 100014,
                Przebieg = 1000,
                RodzajPaliwa = "Petrol",
                CreatedAt = DateTime.Now,
                IsAdActive = true,
                IsAdPaid = true,
                CarUserId = "11"
            }
            );
        }
    }
}


