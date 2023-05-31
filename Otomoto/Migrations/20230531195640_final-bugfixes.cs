using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Otomoto.Migrations
{
    public partial class finalbugfixes : Migration
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
                values: new object[] { 25000, new DateTime(2023, 5, 31, 21, 56, 39, 701, DateTimeKind.Local).AddTicks(9014), 15000 });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 2,
                columns: new[] { "Cena", "CreatedAt", "Przebieg" },
                values: new object[] { 20000, new DateTime(2023, 5, 31, 21, 56, 39, 701, DateTimeKind.Local).AddTicks(9047), 50000 });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 3,
                columns: new[] { "Cena", "CreatedAt", "Przebieg" },
                values: new object[] { 18000, new DateTime(2023, 5, 31, 21, 56, 39, 701, DateTimeKind.Local).AddTicks(9051), 30000 });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 4,
                columns: new[] { "Cena", "CreatedAt", "Przebieg" },
                values: new object[] { 30000, new DateTime(2023, 5, 31, 21, 56, 39, 701, DateTimeKind.Local).AddTicks(9054), 0 });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 5,
                columns: new[] { "Cena", "CreatedAt", "Przebieg" },
                values: new object[] { 20000, new DateTime(2023, 5, 31, 21, 56, 39, 701, DateTimeKind.Local).AddTicks(9057), 0 });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 6,
                columns: new[] { "Cena", "CreatedAt", "Przebieg" },
                values: new object[] { 45000, new DateTime(2023, 5, 31, 21, 56, 39, 701, DateTimeKind.Local).AddTicks(9059), 20000 });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 7,
                columns: new[] { "Cena", "CreatedAt", "Przebieg" },
                values: new object[] { 60000, new DateTime(2023, 5, 31, 21, 56, 39, 701, DateTimeKind.Local).AddTicks(9062), 1000 });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 8,
                columns: new[] { "Cena", "CreatedAt", "Przebieg" },
                values: new object[] { 28000, new DateTime(2023, 5, 31, 21, 56, 39, 701, DateTimeKind.Local).AddTicks(9065), 12000 });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 9,
                columns: new[] { "Cena", "CreatedAt", "Przebieg" },
                values: new object[] { 15000, new DateTime(2023, 5, 31, 21, 56, 39, 701, DateTimeKind.Local).AddTicks(9068), 5000 });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 10,
                columns: new[] { "Cena", "CreatedAt", "Przebieg" },
                values: new object[] { 22000, new DateTime(2023, 5, 31, 21, 56, 39, 701, DateTimeKind.Local).AddTicks(9071), 8000 });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 11,
                columns: new[] { "Cena", "CreatedAt", "Przebieg" },
                values: new object[] { 45000, new DateTime(2023, 5, 31, 21, 56, 39, 701, DateTimeKind.Local).AddTicks(9074), 10000 });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 12,
                columns: new[] { "Cena", "CreatedAt", "Przebieg" },
                values: new object[] { 38000, new DateTime(2023, 5, 31, 21, 56, 39, 701, DateTimeKind.Local).AddTicks(9076), 5000 });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 13,
                columns: new[] { "Cena", "CreatedAt", "Przebieg" },
                values: new object[] { 55000, new DateTime(2023, 5, 31, 21, 56, 39, 701, DateTimeKind.Local).AddTicks(9079), 8000 });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 14,
                columns: new[] { "Cena", "CreatedAt", "Przebieg" },
                values: new object[] { 42000, new DateTime(2023, 5, 31, 21, 56, 39, 701, DateTimeKind.Local).AddTicks(9089), 500 });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 15,
                columns: new[] { "Cena", "CreatedAt", "Przebieg" },
                values: new object[] { 50000, new DateTime(2023, 5, 31, 21, 56, 39, 701, DateTimeKind.Local).AddTicks(9092), 1000 });
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
                values: new object[] { 25000m, new DateTime(2023, 5, 31, 21, 42, 7, 465, DateTimeKind.Local).AddTicks(9421), 15000m });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 2,
                columns: new[] { "Cena", "CreatedAt", "Przebieg" },
                values: new object[] { 20000m, new DateTime(2023, 5, 31, 21, 42, 7, 465, DateTimeKind.Local).AddTicks(9455), 50000m });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 3,
                columns: new[] { "Cena", "CreatedAt", "Przebieg" },
                values: new object[] { 18000m, new DateTime(2023, 5, 31, 21, 42, 7, 465, DateTimeKind.Local).AddTicks(9458), 30000m });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 4,
                columns: new[] { "Cena", "CreatedAt", "Przebieg" },
                values: new object[] { 30000m, new DateTime(2023, 5, 31, 21, 42, 7, 465, DateTimeKind.Local).AddTicks(9462), 0m });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 5,
                columns: new[] { "Cena", "CreatedAt", "Przebieg" },
                values: new object[] { 20000m, new DateTime(2023, 5, 31, 21, 42, 7, 465, DateTimeKind.Local).AddTicks(9464), 0m });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 6,
                columns: new[] { "Cena", "CreatedAt", "Przebieg" },
                values: new object[] { 45000m, new DateTime(2023, 5, 31, 21, 42, 7, 465, DateTimeKind.Local).AddTicks(9467), 20000m });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 7,
                columns: new[] { "Cena", "CreatedAt", "Przebieg" },
                values: new object[] { 60000m, new DateTime(2023, 5, 31, 21, 42, 7, 465, DateTimeKind.Local).AddTicks(9469), 1000m });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 8,
                columns: new[] { "Cena", "CreatedAt", "Przebieg" },
                values: new object[] { 28000m, new DateTime(2023, 5, 31, 21, 42, 7, 465, DateTimeKind.Local).AddTicks(9474), 12000m });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 9,
                columns: new[] { "Cena", "CreatedAt", "Przebieg" },
                values: new object[] { 15000m, new DateTime(2023, 5, 31, 21, 42, 7, 465, DateTimeKind.Local).AddTicks(9477), 5000m });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 10,
                columns: new[] { "Cena", "CreatedAt", "Przebieg" },
                values: new object[] { 22000m, new DateTime(2023, 5, 31, 21, 42, 7, 465, DateTimeKind.Local).AddTicks(9479), 8000m });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 11,
                columns: new[] { "Cena", "CreatedAt", "Przebieg" },
                values: new object[] { 45000m, new DateTime(2023, 5, 31, 21, 42, 7, 465, DateTimeKind.Local).AddTicks(9482), 10000m });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 12,
                columns: new[] { "Cena", "CreatedAt", "Przebieg" },
                values: new object[] { 38000m, new DateTime(2023, 5, 31, 21, 42, 7, 465, DateTimeKind.Local).AddTicks(9484), 5000m });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 13,
                columns: new[] { "Cena", "CreatedAt", "Przebieg" },
                values: new object[] { 55000m, new DateTime(2023, 5, 31, 21, 42, 7, 465, DateTimeKind.Local).AddTicks(9486), 8000m });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 14,
                columns: new[] { "Cena", "CreatedAt", "Przebieg" },
                values: new object[] { 42000m, new DateTime(2023, 5, 31, 21, 42, 7, 465, DateTimeKind.Local).AddTicks(9489), 500m });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 15,
                columns: new[] { "Cena", "CreatedAt", "Przebieg" },
                values: new object[] { 50000m, new DateTime(2023, 5, 31, 21, 42, 7, 465, DateTimeKind.Local).AddTicks(9492), 1000m });
        }
    }
}
