using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Otomoto.Data.Migrations
{
    public partial class image : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<byte[]>(
                name: "CarPicture",
                schema: "Identity",
                table: "Cars",
                type: "varbinary(max)",
                nullable: true,
                oldClrType: typeof(byte[]),
                oldType: "image",
                oldNullable: true);

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 21, 17, 38, 30, 432, DateTimeKind.Local).AddTicks(1956));

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 21, 17, 38, 30, 432, DateTimeKind.Local).AddTicks(1990));

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 21, 17, 38, 30, 432, DateTimeKind.Local).AddTicks(1993));

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 21, 17, 38, 30, 432, DateTimeKind.Local).AddTicks(1998));

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 21, 17, 38, 30, 432, DateTimeKind.Local).AddTicks(2002));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<byte[]>(
                name: "CarPicture",
                schema: "Identity",
                table: "Cars",
                type: "image",
                nullable: true,
                oldClrType: typeof(byte[]),
                oldType: "varbinary(max)",
                oldNullable: true);

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
    }
}
