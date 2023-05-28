using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Otomoto.Migrations
{
    public partial class final_1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 1,
                columns: new[] { "CreatedAt", "RodzajPaliwa", "SkrzyniaBiegow" },
                values: new object[] { new DateTime(2023, 5, 25, 23, 10, 56, 913, DateTimeKind.Local).AddTicks(6028), "Benzyna", "Automatyczna" });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 2,
                columns: new[] { "CreatedAt", "SkrzyniaBiegow" },
                values: new object[] { new DateTime(2023, 5, 25, 23, 10, 56, 913, DateTimeKind.Local).AddTicks(6061), "Automatyczna" });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 3,
                columns: new[] { "CreatedAt", "RodzajPaliwa", "SkrzyniaBiegow" },
                values: new object[] { new DateTime(2023, 5, 25, 23, 10, 56, 913, DateTimeKind.Local).AddTicks(6065), "Benzyna + LPG", "Manualna" });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 4,
                columns: new[] { "CreatedAt", "RodzajPaliwa", "SkrzyniaBiegow" },
                values: new object[] { new DateTime(2023, 5, 25, 23, 10, 56, 913, DateTimeKind.Local).AddTicks(6235), "Benzyna", "Automatyczna" });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 5,
                columns: new[] { "CreatedAt", "SkrzyniaBiegow" },
                values: new object[] { new DateTime(2023, 5, 25, 23, 10, 56, 913, DateTimeKind.Local).AddTicks(6238), "Manualna" });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 6,
                columns: new[] { "CreatedAt", "SkrzyniaBiegow" },
                values: new object[] { new DateTime(2023, 5, 25, 23, 10, 56, 913, DateTimeKind.Local).AddTicks(6241), "Automatyczna" });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 25, 23, 10, 56, 913, DateTimeKind.Local).AddTicks(6243));

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 8,
                columns: new[] { "CreatedAt", "RodzajPaliwa" },
                values: new object[] { new DateTime(2023, 5, 25, 23, 10, 56, 913, DateTimeKind.Local).AddTicks(6246), "Benzyna" });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 9,
                columns: new[] { "CreatedAt", "RodzajPaliwa", "SkrzyniaBiegow" },
                values: new object[] { new DateTime(2023, 5, 25, 23, 10, 56, 913, DateTimeKind.Local).AddTicks(6249), "Benzyna", "Manualna" });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 10,
                columns: new[] { "CreatedAt", "RodzajPaliwa", "SkrzyniaBiegow" },
                values: new object[] { new DateTime(2023, 5, 25, 23, 10, 56, 913, DateTimeKind.Local).AddTicks(6253), "Elektryczne", "Automatyczna" });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 11,
                columns: new[] { "CreatedAt", "RodzajPaliwa", "SkrzyniaBiegow" },
                values: new object[] { new DateTime(2023, 5, 25, 23, 10, 56, 913, DateTimeKind.Local).AddTicks(6256), "Benzyna", "Automatyczna" });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 12,
                columns: new[] { "CreatedAt", "SkrzyniaBiegow" },
                values: new object[] { new DateTime(2023, 5, 25, 23, 10, 56, 913, DateTimeKind.Local).AddTicks(6259), "Automatyczna" });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 13,
                columns: new[] { "CreatedAt", "RodzajPaliwa", "SkrzyniaBiegow" },
                values: new object[] { new DateTime(2023, 5, 25, 23, 10, 56, 913, DateTimeKind.Local).AddTicks(6262), "Benzyna", "Automatyczna" });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 14,
                columns: new[] { "CreatedAt", "RodzajPaliwa", "SkrzyniaBiegow" },
                values: new object[] { new DateTime(2023, 5, 25, 23, 10, 56, 913, DateTimeKind.Local).AddTicks(6265), "Benzyna", "Manualna" });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 15,
                columns: new[] { "CreatedAt", "RodzajPaliwa", "SkrzyniaBiegow" },
                values: new object[] { new DateTime(2023, 5, 25, 23, 10, 56, 913, DateTimeKind.Local).AddTicks(6267), "Benzyna", "Automatyczna" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 1,
                columns: new[] { "CreatedAt", "RodzajPaliwa", "SkrzyniaBiegow" },
                values: new object[] { new DateTime(2023, 5, 25, 13, 44, 40, 682, DateTimeKind.Local).AddTicks(4707), "Petrol", "Automatic" });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 2,
                columns: new[] { "CreatedAt", "SkrzyniaBiegow" },
                values: new object[] { new DateTime(2023, 5, 25, 13, 44, 40, 682, DateTimeKind.Local).AddTicks(4752), "Automatic" });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 3,
                columns: new[] { "CreatedAt", "RodzajPaliwa", "SkrzyniaBiegow" },
                values: new object[] { new DateTime(2023, 5, 25, 13, 44, 40, 682, DateTimeKind.Local).AddTicks(4756), "Petrol", "Manual" });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 4,
                columns: new[] { "CreatedAt", "RodzajPaliwa", "SkrzyniaBiegow" },
                values: new object[] { new DateTime(2023, 5, 25, 13, 44, 40, 682, DateTimeKind.Local).AddTicks(4761), "Petrol", "Automatic" });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 5,
                columns: new[] { "CreatedAt", "SkrzyniaBiegow" },
                values: new object[] { new DateTime(2023, 5, 25, 13, 44, 40, 682, DateTimeKind.Local).AddTicks(4764), "Manual" });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 6,
                columns: new[] { "CreatedAt", "SkrzyniaBiegow" },
                values: new object[] { new DateTime(2023, 5, 25, 13, 44, 40, 682, DateTimeKind.Local).AddTicks(4767), "Automatic" });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 25, 13, 44, 40, 682, DateTimeKind.Local).AddTicks(4770));

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 8,
                columns: new[] { "CreatedAt", "RodzajPaliwa" },
                values: new object[] { new DateTime(2023, 5, 25, 13, 44, 40, 682, DateTimeKind.Local).AddTicks(4773), "Petrol" });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 9,
                columns: new[] { "CreatedAt", "RodzajPaliwa", "SkrzyniaBiegow" },
                values: new object[] { new DateTime(2023, 5, 25, 13, 44, 40, 682, DateTimeKind.Local).AddTicks(4777), "Petrol", "Manual" });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 10,
                columns: new[] { "CreatedAt", "RodzajPaliwa", "SkrzyniaBiegow" },
                values: new object[] { new DateTime(2023, 5, 25, 13, 44, 40, 682, DateTimeKind.Local).AddTicks(4780), "Hybrid", "Automatic" });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 11,
                columns: new[] { "CreatedAt", "RodzajPaliwa", "SkrzyniaBiegow" },
                values: new object[] { new DateTime(2023, 5, 25, 13, 44, 40, 682, DateTimeKind.Local).AddTicks(4783), "Petrol", "Automatic" });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 12,
                columns: new[] { "CreatedAt", "SkrzyniaBiegow" },
                values: new object[] { new DateTime(2023, 5, 25, 13, 44, 40, 682, DateTimeKind.Local).AddTicks(4786), "Automatic" });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 13,
                columns: new[] { "CreatedAt", "RodzajPaliwa", "SkrzyniaBiegow" },
                values: new object[] { new DateTime(2023, 5, 25, 13, 44, 40, 682, DateTimeKind.Local).AddTicks(4790), "Petrol", "Automatic" });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 14,
                columns: new[] { "CreatedAt", "RodzajPaliwa", "SkrzyniaBiegow" },
                values: new object[] { new DateTime(2023, 5, 25, 13, 44, 40, 682, DateTimeKind.Local).AddTicks(4796), "Petrol", "Manual" });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 15,
                columns: new[] { "CreatedAt", "RodzajPaliwa", "SkrzyniaBiegow" },
                values: new object[] { new DateTime(2023, 5, 25, 13, 44, 40, 682, DateTimeKind.Local).AddTicks(4799), "Petrol", "Automatic" });
        }
    }
}
