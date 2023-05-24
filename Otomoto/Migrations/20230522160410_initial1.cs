using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Otomoto.Migrations
{
    public partial class initial1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 22, 18, 4, 10, 100, DateTimeKind.Local).AddTicks(7381));

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 22, 18, 4, 10, 100, DateTimeKind.Local).AddTicks(7414));

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 22, 18, 4, 10, 100, DateTimeKind.Local).AddTicks(7417));

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 22, 18, 4, 10, 100, DateTimeKind.Local).AddTicks(7420));

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 22, 18, 4, 10, 100, DateTimeKind.Local).AddTicks(7424));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 22, 3, 49, 37, 756, DateTimeKind.Local).AddTicks(8760));

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 22, 3, 49, 37, 756, DateTimeKind.Local).AddTicks(8792));

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 22, 3, 49, 37, 756, DateTimeKind.Local).AddTicks(8796));

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 22, 3, 49, 37, 756, DateTimeKind.Local).AddTicks(8799));

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 22, 3, 49, 37, 756, DateTimeKind.Local).AddTicks(8801));
        }
    }
}
