using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Villas_VillaApi.Migrations
{
    public partial class AddDataToVillaTableToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Villas",
                columns: new[] { "Id", "Amenity", "CreatedDate", "Details", "ImageUrl", "Name", "Occupancy", "Rate", "Sqft", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "", new DateTime(2023, 9, 21, 21, 49, 40, 312, DateTimeKind.Local).AddTicks(5778), "This is a Magniificient Villa", "", "Royal Villa", 2, 1000.0, 760, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "", new DateTime(2023, 9, 21, 21, 49, 40, 312, DateTimeKind.Local).AddTicks(5798), "This is a Magnificient Villa with a Pool", "", "Royal Pool Villa", 4, 1500.0, 1000, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, "", new DateTime(2023, 9, 21, 21, 49, 40, 312, DateTimeKind.Local).AddTicks(5799), "This is a Premium Villa with exquisite taste", "", "Premium Villa", 2, 2000.0, 1560, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, "", new DateTime(2023, 9, 21, 21, 49, 40, 312, DateTimeKind.Local).AddTicks(5801), "This is a premium villa with exquisite taste and a pool", "", "Premium Pool Villa", 4, 4000.0, 2100, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, "", new DateTime(2023, 9, 21, 21, 49, 40, 312, DateTimeKind.Local).AddTicks(5803), "This is a luxuriously exqusite and lavish villa", "", "Diamond Villa", 4, 7000.0, 3600, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
