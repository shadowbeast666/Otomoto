﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Otomoto.Data;

#nullable disable

namespace Otomoto.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230525114441_Final_0")]
    partial class Final_0
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("Identity")
                .HasAnnotation("ProductVersion", "6.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("Role", "Identity");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("RoleClaims", "Identity");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", "Identity");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("UserClaims", "Identity");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("UserLogins", "Identity");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("UserRoles", "Identity");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("UserTokens", "Identity");
                });

            modelBuilder.Entity("Otomoto.Models.Car", b =>
                {
                    b.Property<int>("CarId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CarId"), 1L, 1);

                    b.Property<byte[]>("CarPicture")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("CarUserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Cena")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsAdActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsAdPaid")
                        .HasColumnType("bit");

                    b.Property<string>("Marka")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Opis")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pojemnosc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Przebieg")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("RodzajPaliwa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RokProdukcji")
                        .HasColumnType("int");

                    b.Property<string>("SkrzyniaBiegow")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Typ")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Vin")
                        .HasColumnType("int");

                    b.HasKey("CarId");

                    b.ToTable("Cars", "Identity");

                    b.HasData(
                        new
                        {
                            CarId = 1,
                            CarUserId = "5",
                            Cena = 25000m,
                            CreatedAt = new DateTime(2023, 5, 25, 13, 44, 40, 682, DateTimeKind.Local).AddTicks(4707),
                            IsAdActive = true,
                            IsAdPaid = true,
                            Marka = "Toyota",
                            Model = "Camry",
                            Opis = "Spacious interior, excellent safety features",
                            Pojemnosc = "2.5L",
                            Przebieg = 15000m,
                            RodzajPaliwa = "Petrol",
                            RokProdukcji = 2022,
                            SkrzyniaBiegow = "Automatic",
                            Typ = "Sedan",
                            Vin = 100003
                        },
                        new
                        {
                            CarId = 2,
                            CarUserId = "2",
                            Cena = 20000m,
                            CreatedAt = new DateTime(2023, 5, 25, 13, 44, 40, 682, DateTimeKind.Local).AddTicks(4752),
                            IsAdActive = true,
                            IsAdPaid = true,
                            Marka = "Toyota",
                            Model = "Corolla",
                            Opis = "Excellent condition, well maintained",
                            Pojemnosc = "1.8L",
                            Przebieg = 50000m,
                            RodzajPaliwa = "Petrol",
                            RokProdukcji = 2009,
                            SkrzyniaBiegow = "Automatic",
                            Typ = "Sedan",
                            Vin = 100001
                        },
                        new
                        {
                            CarId = 3,
                            CarUserId = "3",
                            Cena = 18000m,
                            CreatedAt = new DateTime(2023, 5, 25, 13, 44, 40, 682, DateTimeKind.Local).AddTicks(4756),
                            IsAdActive = true,
                            IsAdPaid = false,
                            Marka = "Honda",
                            Model = "Civic",
                            Opis = "Low mileage, good fuel efficiency",
                            Pojemnosc = "2.0L",
                            Przebieg = 30000m,
                            RodzajPaliwa = "Petrol",
                            RokProdukcji = 2023,
                            SkrzyniaBiegow = "Manual",
                            Typ = "Hatchback",
                            Vin = 100002
                        },
                        new
                        {
                            CarId = 4,
                            CarUserId = "4",
                            Cena = 30000m,
                            CreatedAt = new DateTime(2023, 5, 25, 13, 44, 40, 682, DateTimeKind.Local).AddTicks(4761),
                            IsAdActive = true,
                            IsAdPaid = false,
                            Marka = "Toyota",
                            Model = "Camry",
                            Opis = "Elegant and comfortable family car",
                            Pojemnosc = "2500cc",
                            Przebieg = 0m,
                            RodzajPaliwa = "Petrol",
                            RokProdukcji = 2021,
                            SkrzyniaBiegow = "Automatic",
                            Typ = "Sedan",
                            Vin = 123456789
                        },
                        new
                        {
                            CarId = 5,
                            CarUserId = "5",
                            Cena = 20000m,
                            CreatedAt = new DateTime(2023, 5, 25, 13, 44, 40, 682, DateTimeKind.Local).AddTicks(4764),
                            IsAdActive = true,
                            IsAdPaid = false,
                            Marka = "Honda",
                            Model = "Civic",
                            Opis = "Sporty, compact and fun to drive",
                            Pojemnosc = "1800cc",
                            Przebieg = 0m,
                            RodzajPaliwa = "Petrol",
                            RokProdukcji = 1998,
                            SkrzyniaBiegow = "Manual",
                            Typ = "Hatchback",
                            Vin = 223456789
                        },
                        new
                        {
                            CarId = 6,
                            CarUserId = "8",
                            Cena = 45000m,
                            CreatedAt = new DateTime(2023, 5, 25, 13, 44, 40, 682, DateTimeKind.Local).AddTicks(4767),
                            IsAdActive = true,
                            IsAdPaid = true,
                            Marka = "Mercedes-Benz",
                            Model = "E-Class",
                            Opis = "Luxurious interior, advanced technology",
                            Pojemnosc = "3.0L",
                            Przebieg = 20000m,
                            RodzajPaliwa = "Diesel",
                            RokProdukcji = 2021,
                            SkrzyniaBiegow = "Automatic",
                            Typ = "Sedan",
                            Vin = 100004
                        },
                        new
                        {
                            CarId = 7,
                            CarUserId = "7",
                            Cena = 60000m,
                            CreatedAt = new DateTime(2023, 5, 25, 13, 44, 40, 682, DateTimeKind.Local).AddTicks(4770),
                            IsAdActive = true,
                            IsAdPaid = true,
                            Marka = "BMW",
                            Model = "M3",
                            Opis = "Powerful engine, sporty design",
                            Pojemnosc = "3.0L",
                            Przebieg = 1000m,
                            RodzajPaliwa = "Petrol",
                            RokProdukcji = 2023,
                            SkrzyniaBiegow = "Automatic",
                            Typ = "Sedan",
                            Vin = 100006
                        },
                        new
                        {
                            CarId = 8,
                            CarUserId = "4",
                            Cena = 28000m,
                            CreatedAt = new DateTime(2023, 5, 25, 13, 44, 40, 682, DateTimeKind.Local).AddTicks(4773),
                            IsAdActive = true,
                            IsAdPaid = true,
                            Marka = "Volkswagen",
                            Model = "Tiguan",
                            Opis = "Family-friendly, spacious seating",
                            Pojemnosc = "2.0L",
                            Przebieg = 12000m,
                            RodzajPaliwa = "Petrol",
                            RokProdukcji = 2022,
                            SkrzyniaBiegow = "Automatic",
                            Typ = "SUV",
                            Vin = 100007
                        },
                        new
                        {
                            CarId = 9,
                            CarUserId = "6",
                            Cena = 15000m,
                            CreatedAt = new DateTime(2023, 5, 25, 13, 44, 40, 682, DateTimeKind.Local).AddTicks(4777),
                            IsAdActive = true,
                            IsAdPaid = false,
                            Marka = "Fiat",
                            Model = "500",
                            Opis = "Compact and agile city car",
                            Pojemnosc = "1.2L",
                            Przebieg = 5000m,
                            RodzajPaliwa = "Petrol",
                            RokProdukcji = 2023,
                            SkrzyniaBiegow = "Manual",
                            Typ = "Hatchback",
                            Vin = 100008
                        },
                        new
                        {
                            CarId = 10,
                            CarUserId = "9",
                            Cena = 22000m,
                            CreatedAt = new DateTime(2023, 5, 25, 13, 44, 40, 682, DateTimeKind.Local).AddTicks(4780),
                            IsAdActive = true,
                            IsAdPaid = true,
                            Marka = "Toyota",
                            Model = "Prius",
                            Opis = "Efficient hybrid with modern features",
                            Pojemnosc = "1.8L",
                            Przebieg = 8000m,
                            RodzajPaliwa = "Hybrid",
                            RokProdukcji = 2022,
                            SkrzyniaBiegow = "Automatic",
                            Typ = "Sedan",
                            Vin = 100009
                        },
                        new
                        {
                            CarId = 11,
                            CarUserId = "7",
                            Cena = 45000m,
                            CreatedAt = new DateTime(2023, 5, 25, 13, 44, 40, 682, DateTimeKind.Local).AddTicks(4783),
                            IsAdActive = true,
                            IsAdPaid = true,
                            Marka = "Mercedes-Benz",
                            Model = "C-Class",
                            Opis = "Powerful performance and luxury",
                            Pojemnosc = "2.0L",
                            Przebieg = 10000m,
                            RodzajPaliwa = "Petrol",
                            RokProdukcji = 2022,
                            SkrzyniaBiegow = "Automatic",
                            Typ = "Sedan",
                            Vin = 100010
                        },
                        new
                        {
                            CarId = 12,
                            CarUserId = "5",
                            Cena = 38000m,
                            CreatedAt = new DateTime(2023, 5, 25, 13, 44, 40, 682, DateTimeKind.Local).AddTicks(4786),
                            IsAdActive = true,
                            IsAdPaid = true,
                            Marka = "Volvo",
                            Model = "XC60",
                            Opis = "Spacious and comfortable SUV",
                            Pojemnosc = "2.0L",
                            Przebieg = 5000m,
                            RodzajPaliwa = "Diesel",
                            RokProdukcji = 2023,
                            SkrzyniaBiegow = "Automatic",
                            Typ = "SUV",
                            Vin = 100011
                        },
                        new
                        {
                            CarId = 13,
                            CarUserId = "8",
                            Cena = 55000m,
                            CreatedAt = new DateTime(2023, 5, 25, 13, 44, 40, 682, DateTimeKind.Local).AddTicks(4790),
                            IsAdActive = true,
                            IsAdPaid = true,
                            Marka = "BMW",
                            Model = "4 Series",
                            Opis = "Sporty and stylish coupe",
                            Pojemnosc = "3.0L",
                            Przebieg = 8000m,
                            RodzajPaliwa = "Petrol",
                            RokProdukcji = 2022,
                            SkrzyniaBiegow = "Automatic",
                            Typ = "Coupe",
                            Vin = 100012
                        },
                        new
                        {
                            CarId = 14,
                            CarUserId = "10",
                            Cena = 42000m,
                            CreatedAt = new DateTime(2023, 5, 25, 13, 44, 40, 682, DateTimeKind.Local).AddTicks(4796),
                            IsAdActive = true,
                            IsAdPaid = true,
                            Marka = "Jeep",
                            Model = "Wrangler",
                            Opis = "Versatile and capable off-road SUV",
                            Pojemnosc = "3.6L",
                            Przebieg = 500m,
                            RodzajPaliwa = "Petrol",
                            RokProdukcji = 2023,
                            SkrzyniaBiegow = "Manual",
                            Typ = "SUV",
                            Vin = 100013
                        },
                        new
                        {
                            CarId = 15,
                            CarUserId = "11",
                            Cena = 50000m,
                            CreatedAt = new DateTime(2023, 5, 25, 13, 44, 40, 682, DateTimeKind.Local).AddTicks(4799),
                            IsAdActive = true,
                            IsAdPaid = true,
                            Marka = "Audi",
                            Model = "A6",
                            Opis = "Elegant and luxurious sedan",
                            Pojemnosc = "2.0L",
                            Przebieg = 1000m,
                            RodzajPaliwa = "Petrol",
                            RokProdukcji = 2023,
                            SkrzyniaBiegow = "Automatic",
                            Typ = "Sedan",
                            Vin = 100014
                        });
                });

            modelBuilder.Entity("Otomoto.Models.CarBrand", b =>
                {
                    b.Property<int>("CarBrandId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CarBrandId"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CarBrandId");

                    b.ToTable("CarBrands", "Identity");
                });

            modelBuilder.Entity("UserManagement.MVC.Models.ApplicationUser", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityUser");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("ProfilePicture")
                        .HasColumnType("varbinary(max)");

                    b.Property<int>("UsernameChangeLimit")
                        .HasColumnType("int");

                    b.ToTable("User", "Identity");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("UserManagement.MVC.Models.ApplicationUser", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithOne()
                        .HasForeignKey("UserManagement.MVC.Models.ApplicationUser", "Id")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
