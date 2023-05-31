using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Otomoto.Migrations
{
    public partial class testfinal : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Przebieg",
                schema: "Identity",
                table: "Cars",
                type: "int",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<int>(
                name: "Cena",
                schema: "Identity",
                table: "Cars",
                type: "int",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 1,
                columns: new[] { "Cena", "CreatedAt", "Przebieg" },
                values: new object[] { 25000, new DateTime(2023, 5, 31, 20, 37, 1, 381, DateTimeKind.Local).AddTicks(2382), 15000 });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 2,
                columns: new[] { "Cena", "CreatedAt", "Przebieg" },
                values: new object[] { 20000, new DateTime(2023, 5, 31, 20, 37, 1, 381, DateTimeKind.Local).AddTicks(2552), 50000 });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 3,
                columns: new[] { "Cena", "CreatedAt", "Przebieg" },
                values: new object[] { 18000, new DateTime(2023, 5, 31, 20, 37, 1, 381, DateTimeKind.Local).AddTicks(2557), 30000 });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 4,
                columns: new[] { "Cena", "CreatedAt", "Przebieg" },
                values: new object[] { 30000, new DateTime(2023, 5, 31, 20, 37, 1, 381, DateTimeKind.Local).AddTicks(2560), 0 });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 5,
                columns: new[] { "Cena", "CreatedAt", "Przebieg" },
                values: new object[] { 20000, new DateTime(2023, 5, 31, 20, 37, 1, 381, DateTimeKind.Local).AddTicks(2563), 0 });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 6,
                columns: new[] { "Cena", "CreatedAt", "Przebieg" },
                values: new object[] { 45000, new DateTime(2023, 5, 31, 20, 37, 1, 381, DateTimeKind.Local).AddTicks(2565), 20000 });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 7,
                columns: new[] { "Cena", "CreatedAt", "Przebieg" },
                values: new object[] { 60000, new DateTime(2023, 5, 31, 20, 37, 1, 381, DateTimeKind.Local).AddTicks(2568), 1000 });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 8,
                columns: new[] { "Cena", "CreatedAt", "Przebieg" },
                values: new object[] { 28000, new DateTime(2023, 5, 31, 20, 37, 1, 381, DateTimeKind.Local).AddTicks(2572), 12000 });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 9,
                columns: new[] { "Cena", "CreatedAt", "Przebieg" },
                values: new object[] { 15000, new DateTime(2023, 5, 31, 20, 37, 1, 381, DateTimeKind.Local).AddTicks(2575), 5000 });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 10,
                columns: new[] { "Cena", "CreatedAt", "Przebieg" },
                values: new object[] { 22000, new DateTime(2023, 5, 31, 20, 37, 1, 381, DateTimeKind.Local).AddTicks(2578), 8000 });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 11,
                columns: new[] { "Cena", "CreatedAt", "Przebieg" },
                values: new object[] { 45000, new DateTime(2023, 5, 31, 20, 37, 1, 381, DateTimeKind.Local).AddTicks(2581), 10000 });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 12,
                columns: new[] { "Cena", "CreatedAt", "Przebieg" },
                values: new object[] { 38000, new DateTime(2023, 5, 31, 20, 37, 1, 381, DateTimeKind.Local).AddTicks(2583), 5000 });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 13,
                columns: new[] { "Cena", "CreatedAt", "Przebieg" },
                values: new object[] { 55000, new DateTime(2023, 5, 31, 20, 37, 1, 381, DateTimeKind.Local).AddTicks(2586), 8000 });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 14,
                columns: new[] { "Cena", "CreatedAt", "Przebieg" },
                values: new object[] { 42000, new DateTime(2023, 5, 31, 20, 37, 1, 381, DateTimeKind.Local).AddTicks(2589), 500 });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 15,
                columns: new[] { "Cena", "CreatedAt", "Przebieg" },
                values: new object[] { 50000, new DateTime(2023, 5, 31, 20, 37, 1, 381, DateTimeKind.Local).AddTicks(2592), 1000 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Przebieg",
                schema: "Identity",
                table: "Cars",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<decimal>(
                name: "Cena",
                schema: "Identity",
                table: "Cars",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 1,
                columns: new[] { "Cena", "CreatedAt", "Przebieg" },
                values: new object[] { 25000m, new DateTime(2023, 5, 25, 23, 10, 56, 913, DateTimeKind.Local).AddTicks(6028), 15000m });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 2,
                columns: new[] { "Cena", "CreatedAt", "Przebieg" },
                values: new object[] { 20000m, new DateTime(2023, 5, 25, 23, 10, 56, 913, DateTimeKind.Local).AddTicks(6061), 50000m });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 3,
                columns: new[] { "Cena", "CreatedAt", "Przebieg" },
                values: new object[] { 18000m, new DateTime(2023, 5, 25, 23, 10, 56, 913, DateTimeKind.Local).AddTicks(6065), 30000m });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 4,
                columns: new[] { "Cena", "CreatedAt", "Przebieg" },
                values: new object[] { 30000m, new DateTime(2023, 5, 25, 23, 10, 56, 913, DateTimeKind.Local).AddTicks(6235), 0m });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 5,
                columns: new[] { "Cena", "CreatedAt", "Przebieg" },
                values: new object[] { 20000m, new DateTime(2023, 5, 25, 23, 10, 56, 913, DateTimeKind.Local).AddTicks(6238), 0m });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 6,
                columns: new[] { "Cena", "CreatedAt", "Przebieg" },
                values: new object[] { 45000m, new DateTime(2023, 5, 25, 23, 10, 56, 913, DateTimeKind.Local).AddTicks(6241), 20000m });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 7,
                columns: new[] { "Cena", "CreatedAt", "Przebieg" },
                values: new object[] { 60000m, new DateTime(2023, 5, 25, 23, 10, 56, 913, DateTimeKind.Local).AddTicks(6243), 1000m });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 8,
                columns: new[] { "Cena", "CreatedAt", "Przebieg" },
                values: new object[] { 28000m, new DateTime(2023, 5, 25, 23, 10, 56, 913, DateTimeKind.Local).AddTicks(6246), 12000m });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 9,
                columns: new[] { "Cena", "CreatedAt", "Przebieg" },
                values: new object[] { 15000m, new DateTime(2023, 5, 25, 23, 10, 56, 913, DateTimeKind.Local).AddTicks(6249), 5000m });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 10,
                columns: new[] { "Cena", "CreatedAt", "Przebieg" },
                values: new object[] { 22000m, new DateTime(2023, 5, 25, 23, 10, 56, 913, DateTimeKind.Local).AddTicks(6253), 8000m });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 11,
                columns: new[] { "Cena", "CreatedAt", "Przebieg" },
                values: new object[] { 45000m, new DateTime(2023, 5, 25, 23, 10, 56, 913, DateTimeKind.Local).AddTicks(6256), 10000m });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 12,
                columns: new[] { "Cena", "CreatedAt", "Przebieg" },
                values: new object[] { 38000m, new DateTime(2023, 5, 25, 23, 10, 56, 913, DateTimeKind.Local).AddTicks(6259), 5000m });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 13,
                columns: new[] { "Cena", "CreatedAt", "Przebieg" },
                values: new object[] { 55000m, new DateTime(2023, 5, 25, 23, 10, 56, 913, DateTimeKind.Local).AddTicks(6262), 8000m });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 14,
                columns: new[] { "Cena", "CreatedAt", "Przebieg" },
                values: new object[] { 42000m, new DateTime(2023, 5, 25, 23, 10, 56, 913, DateTimeKind.Local).AddTicks(6265), 500m });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 15,
                columns: new[] { "Cena", "CreatedAt", "Przebieg" },
                values: new object[] { 50000m, new DateTime(2023, 5, 25, 23, 10, 56, 913, DateTimeKind.Local).AddTicks(6267), 1000m });
        }
    }
}
