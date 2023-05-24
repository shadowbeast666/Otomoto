using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Otomoto.Migrations
{
    public partial class test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CarUserId",
                schema: "Identity",
                table: "Cars",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 1,
                columns: new[] { "CarUserId", "CreatedAt" },
                values: new object[] { "1", new DateTime(2023, 5, 23, 17, 24, 12, 353, DateTimeKind.Local).AddTicks(1871) });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 2,
                columns: new[] { "CarUserId", "CreatedAt" },
                values: new object[] { "2", new DateTime(2023, 5, 23, 17, 24, 12, 353, DateTimeKind.Local).AddTicks(1903) });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 3,
                columns: new[] { "CarUserId", "CreatedAt" },
                values: new object[] { "3", new DateTime(2023, 5, 23, 17, 24, 12, 353, DateTimeKind.Local).AddTicks(1907) });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 4,
                columns: new[] { "CarUserId", "CreatedAt" },
                values: new object[] { "4", new DateTime(2023, 5, 23, 17, 24, 12, 353, DateTimeKind.Local).AddTicks(1911) });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 5,
                columns: new[] { "CarUserId", "CreatedAt" },
                values: new object[] { "5", new DateTime(2023, 5, 23, 17, 24, 12, 353, DateTimeKind.Local).AddTicks(1913) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CarUserId",
                schema: "Identity",
                table: "Cars");

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
    }
}
