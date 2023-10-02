using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Villas_VillaApi.Migrations
{
    public partial class DisableNUll : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 28, 14, 4, 4, 320, DateTimeKind.Local).AddTicks(1786));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 28, 14, 4, 4, 320, DateTimeKind.Local).AddTicks(1814));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 28, 14, 4, 4, 320, DateTimeKind.Local).AddTicks(1819));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 28, 14, 4, 4, 320, DateTimeKind.Local).AddTicks(1824));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 28, 14, 4, 4, 320, DateTimeKind.Local).AddTicks(1827));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 27, 13, 3, 50, 906, DateTimeKind.Local).AddTicks(7095));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 27, 13, 3, 50, 906, DateTimeKind.Local).AddTicks(7107));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 27, 13, 3, 50, 906, DateTimeKind.Local).AddTicks(7109));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 27, 13, 3, 50, 906, DateTimeKind.Local).AddTicks(7111));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 27, 13, 3, 50, 906, DateTimeKind.Local).AddTicks(7112));
        }
    }
}
