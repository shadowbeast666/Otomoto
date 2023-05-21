using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Otomoto.Data.Migrations
{
    public partial class Car_Seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<byte[]>(
                name: "ProfilePicture",
                schema: "Identity",
                table: "User",
                type: "varbinary(max)",
                nullable: true,
                oldClrType: typeof(byte[]),
                oldType: "varbinary(max)");

            migrationBuilder.CreateTable(
                name: "Cars",
                schema: "Identity",
                columns: table => new
                {
                    CarId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Opis = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Marka = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Typ = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Pojemnosc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SkrzyniaBiegow = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RokProdukcji = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Cena = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Vin = table.Column<int>(type: "int", nullable: false),
                    Przebieg = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    RodzajPaliwa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsAdActive = table.Column<bool>(type: "bit", nullable: false),
                    IsAdPaid = table.Column<bool>(type: "bit", nullable: false),
                    CarPicture = table.Column<byte[]>(type: "image", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.CarId);
                });

            migrationBuilder.InsertData(
                schema: "Identity",
                table: "Cars",
                columns: new[] { "CarId", "CarPicture", "Cena", "CreatedAt", "IsAdActive", "IsAdPaid", "Marka", "Model", "Opis", "Pojemnosc", "Przebieg", "RodzajPaliwa", "RokProdukcji", "SkrzyniaBiegow", "Typ", "Vin" },
                values: new object[,]
                {
                    { 1, null, 10000m, new DateTime(2023, 5, 21, 14, 53, 41, 372, DateTimeKind.Local).AddTicks(3899), true, false, "Marka1", "Model1", "Opis1", "Pojemnosc1", 10000m, "RodzajPaliwa1", new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "SkrzyniaBiegow1", "Typ1", 123456 },
                    { 2, null, 20000m, new DateTime(2023, 5, 21, 14, 53, 41, 372, DateTimeKind.Local).AddTicks(3937), true, true, "Toyota", "Corolla", "Excellent condition, well maintained", "1.8L", 50000m, "Petrol", new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Automatic", "Sedan", 100001 },
                    { 3, null, 18000m, new DateTime(2023, 5, 21, 14, 53, 41, 372, DateTimeKind.Local).AddTicks(3940), true, false, "Honda", "Civic", "Low mileage, good fuel efficiency", "2.0L", 30000m, "Petrol", new DateTime(2018, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Manual", "Hatchback", 100002 },
                    { 4, null, 30000m, new DateTime(2023, 5, 21, 14, 53, 41, 372, DateTimeKind.Local).AddTicks(3945), true, false, "Toyota", "Camry", "Elegant and comfortable family car", "2500cc", 0m, "Petrol", new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Automatic", "Sedan", 123456789 },
                    { 5, null, 20000m, new DateTime(2023, 5, 21, 14, 53, 41, 372, DateTimeKind.Local).AddTicks(3947), true, false, "Honda", "Civic", "Sporty, compact and fun to drive", "1800cc", 0m, "Petrol", new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Manual", "Hatchback", 223456789 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cars",
                schema: "Identity");

            migrationBuilder.AlterColumn<byte[]>(
                name: "ProfilePicture",
                schema: "Identity",
                table: "User",
                type: "varbinary(max)",
                nullable: false,
                defaultValue: new byte[0],
                oldClrType: typeof(byte[]),
                oldType: "varbinary(max)",
                oldNullable: true);
        }
    }
}
