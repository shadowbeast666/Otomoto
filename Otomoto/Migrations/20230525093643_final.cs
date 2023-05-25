using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Otomoto.Migrations
{
    public partial class final : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 1,
                columns: new[] { "CarUserId", "Cena", "CreatedAt", "IsAdPaid", "Marka", "Model", "Opis", "Pojemnosc", "Przebieg", "RodzajPaliwa", "RokProdukcji", "SkrzyniaBiegow", "Typ", "Vin" },
                values: new object[] { "5", 25000m, new DateTime(2023, 5, 25, 11, 36, 43, 279, DateTimeKind.Local).AddTicks(8469), true, "Toyota", "Camry", "Spacious interior, excellent safety features", "2.5L", 15000m, "Petrol", 2022, "Automatic", "Sedan", 100003 });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 25, 11, 36, 43, 279, DateTimeKind.Local).AddTicks(8504));

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 25, 11, 36, 43, 279, DateTimeKind.Local).AddTicks(8508));

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 25, 11, 36, 43, 279, DateTimeKind.Local).AddTicks(8511));

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 25, 11, 36, 43, 279, DateTimeKind.Local).AddTicks(8514));

            migrationBuilder.InsertData(
                schema: "Identity",
                table: "Cars",
                columns: new[] { "CarId", "CarPicture", "CarUserId", "Cena", "CreatedAt", "IsAdActive", "IsAdPaid", "Marka", "Model", "Opis", "Pojemnosc", "Przebieg", "RodzajPaliwa", "RokProdukcji", "SkrzyniaBiegow", "Typ", "Vin" },
                values: new object[,]
                {
                    { 6, null, "8", 45000m, new DateTime(2023, 5, 25, 11, 36, 43, 279, DateTimeKind.Local).AddTicks(8517), true, true, "Mercedes-Benz", "E-Class", "Luxurious interior, advanced technology", "3.0L", 20000m, "Diesel", 2021, "Automatic", "Sedan", 100004 },
                    { 7, null, "7", 60000m, new DateTime(2023, 5, 25, 11, 36, 43, 279, DateTimeKind.Local).AddTicks(8520), true, true, "BMW", "M3", "Powerful engine, sporty design", "3.0L", 1000m, "Petrol", 2023, "Automatic", "Sedan", 100006 },
                    { 8, null, "4", 28000m, new DateTime(2023, 5, 25, 11, 36, 43, 279, DateTimeKind.Local).AddTicks(8522), true, true, "Volkswagen", "Tiguan", "Family-friendly, spacious seating", "2.0L", 12000m, "Petrol", 2022, "Automatic", "SUV", 100007 },
                    { 9, null, "6", 15000m, new DateTime(2023, 5, 25, 11, 36, 43, 279, DateTimeKind.Local).AddTicks(8525), true, false, "Fiat", "500", "Compact and agile city car", "1.2L", 5000m, "Petrol", 2023, "Manual", "Hatchback", 100008 },
                    { 10, null, "9", 22000m, new DateTime(2023, 5, 25, 11, 36, 43, 279, DateTimeKind.Local).AddTicks(8527), true, true, "Toyota", "Prius", "Efficient hybrid with modern features", "1.8L", 8000m, "Hybrid", 2022, "Automatic", "Sedan", 100009 },
                    { 11, null, "7", 45000m, new DateTime(2023, 5, 25, 11, 36, 43, 279, DateTimeKind.Local).AddTicks(8530), true, true, "Mercedes-Benz", "C-Class", "Powerful performance and luxury", "2.0L", 10000m, "Petrol", 2022, "Automatic", "Sedan", 100010 },
                    { 12, null, "5", 38000m, new DateTime(2023, 5, 25, 11, 36, 43, 279, DateTimeKind.Local).AddTicks(8533), true, true, "Volvo", "XC60", "Spacious and comfortable SUV", "2.0L", 5000m, "Diesel", 2023, "Automatic", "SUV", 100011 },
                    { 13, null, "8", 55000m, new DateTime(2023, 5, 25, 11, 36, 43, 279, DateTimeKind.Local).AddTicks(8536), true, true, "BMW", "4 Series", "Sporty and stylish coupe", "3.0L", 8000m, "Petrol", 2022, "Automatic", "Coupe", 100012 },
                    { 14, null, "10", 42000m, new DateTime(2023, 5, 25, 11, 36, 43, 279, DateTimeKind.Local).AddTicks(8539), true, true, "Jeep", "Wrangler", "Versatile and capable off-road SUV", "3.6L", 500m, "Petrol", 2023, "Manual", "SUV", 100013 },
                    { 15, null, "11", 50000m, new DateTime(2023, 5, 25, 11, 36, 43, 279, DateTimeKind.Local).AddTicks(8544), true, true, "Audi", "A6", "Elegant and luxurious sedan", "2.0L", 1000m, "Petrol", 2023, "Automatic", "Sedan", 100014 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 15);

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 1,
                columns: new[] { "CarUserId", "Cena", "CreatedAt", "IsAdPaid", "Marka", "Model", "Opis", "Pojemnosc", "Przebieg", "RodzajPaliwa", "RokProdukcji", "SkrzyniaBiegow", "Typ", "Vin" },
                values: new object[] { "1", 10000m, new DateTime(2023, 5, 23, 17, 24, 12, 353, DateTimeKind.Local).AddTicks(1871), false, "BMW", "Model1", "Opis1", "Pojemnosc1", 10000m, "RodzajPaliwa1", 2000, "SkrzyniaBiegow1", "Typ1", 123456 });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 23, 17, 24, 12, 353, DateTimeKind.Local).AddTicks(1903));

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 23, 17, 24, 12, 353, DateTimeKind.Local).AddTicks(1907));

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 23, 17, 24, 12, 353, DateTimeKind.Local).AddTicks(1911));

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 23, 17, 24, 12, 353, DateTimeKind.Local).AddTicks(1913));
        }
    }
}
