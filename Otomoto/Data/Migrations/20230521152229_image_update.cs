using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Otomoto.Data.Migrations
{
    public partial class image_update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 21, 17, 22, 28, 688, DateTimeKind.Local).AddTicks(4222));

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 21, 17, 22, 28, 688, DateTimeKind.Local).AddTicks(4257));

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 21, 17, 22, 28, 688, DateTimeKind.Local).AddTicks(4260));

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 21, 17, 22, 28, 688, DateTimeKind.Local).AddTicks(4263));

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 21, 17, 22, 28, 688, DateTimeKind.Local).AddTicks(4267));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 21, 14, 53, 41, 372, DateTimeKind.Local).AddTicks(3899));

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 21, 14, 53, 41, 372, DateTimeKind.Local).AddTicks(3937));

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 21, 14, 53, 41, 372, DateTimeKind.Local).AddTicks(3940));

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 21, 14, 53, 41, 372, DateTimeKind.Local).AddTicks(3945));

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 21, 14, 53, 41, 372, DateTimeKind.Local).AddTicks(3947));
        }
    }
}
