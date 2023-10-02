using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Villas_VillaApi.Migrations
{
    public partial class AddVillaNumberTableToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "villaNumbers",
                columns: table => new
                {
                    VillaNo = table.Column<int>(type: "int", nullable: false),
                    VillaId = table.Column<int>(type: "int", nullable: false),
                    SpecialDetails = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_villaNumbers", x => x.VillaNo);
                    table.ForeignKey(
                        name: "FK_villaNumbers_Villas_VillaId",
                        column: x => x.VillaId,
                        principalTable: "Villas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Details", "ImageUrl", "Rate", "Sqft" },
                values: new object[] { new DateTime(2023, 9, 25, 11, 15, 18, 650, DateTimeKind.Local).AddTicks(8979), "Neque porro quisquam est qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit...", "https://www.google.com/url?sa=i&url=https%3A%2F%2Funsplash.com%2Fs%2Fphotos%2Fvilla&psig=AOvVaw0pByoKewJvb4TImGr28PGO&ust=1694522629380000&source=images&cd=vfe&opi=89978449&ved=0CBAQjRxqFwoTCIDm_uvKooEDFQAAAAAdAAAAABAE", 700.0, 600 });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Details", "ImageUrl", "Occupancy", "Rate", "Sqft" },
                values: new object[] { new DateTime(2023, 9, 25, 11, 15, 18, 650, DateTimeKind.Local).AddTicks(9001), "Neque porro quisquam est qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit...", "https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.istockphoto.com%2Fphotos%2Fvilla&psig=AOvVaw0pByoKewJvb4TImGr28PGO&ust=1694522629380000&source=images&cd=vfe&opi=89978449&ved=0CBAQjRxqFwoTCIDm_uvKooEDFQAAAAAdAAAAABAI", 2, 790.0, 650 });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Details", "ImageUrl", "Occupancy", "Rate", "Sqft" },
                values: new object[] { new DateTime(2023, 9, 25, 11, 15, 18, 650, DateTimeKind.Local).AddTicks(9005), "Neque porro quisquam est qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit...", "https://www.google.com/url?sa=i&url=https%3A%2F%2Fstock.adobe.com%2Fsearch%3Fk%3Dvilla&psig=AOvVaw0pByoKewJvb4TImGr28PGO&ust=1694522629380000&source=images&cd=vfe&opi=89978449&ved=0CBAQjRxqFwoTCIDm_uvKooEDFQAAAAAdAAAAABAQ", 3, 1000.0, 750 });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Details", "ImageUrl", "Occupancy", "Rate", "Sqft" },
                values: new object[] { new DateTime(2023, 9, 25, 11, 15, 18, 650, DateTimeKind.Local).AddTicks(9008), "Neque porro quisquam est qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit...", "https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.shutterstock.com%2Fsearch%2Fvilla&psig=AOvVaw0pByoKewJvb4TImGr28PGO&ust=1694522629380000&source=images&cd=vfe&opi=89978449&ved=0CBAQjRxqFwoTCIDm_uvKooEDFQAAAAAdAAAAABAY", 3, 1500.0, 1050 });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Details", "ImageUrl", "Rate", "Sqft" },
                values: new object[] { new DateTime(2023, 9, 25, 11, 15, 18, 650, DateTimeKind.Local).AddTicks(9010), "Neque porro quisquam est qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit...", "https://www.google.com/url?sa=i&url=https%3A%2F%2Funsplash.com%2Fs%2Fphotos%2Fvilla&psig=AOvVaw0pByoKewJvb4TImGr28PGO&ust=1694522629380000&source=images&cd=vfe&opi=89978449&ved=0CBAQjRxqFwoTCIDm_uvKooEDFQAAAAAdAAAAABAg", 2000.0, 1550 });

            migrationBuilder.CreateIndex(
                name: "IX_villaNumbers_VillaId",
                table: "villaNumbers",
                column: "VillaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "villaNumbers");

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Details", "ImageUrl", "Rate", "Sqft" },
                values: new object[] { new DateTime(2023, 9, 21, 21, 49, 40, 312, DateTimeKind.Local).AddTicks(5778), "This is a Magniificient Villa", "", 1000.0, 760 });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Details", "ImageUrl", "Occupancy", "Rate", "Sqft" },
                values: new object[] { new DateTime(2023, 9, 21, 21, 49, 40, 312, DateTimeKind.Local).AddTicks(5798), "This is a Magnificient Villa with a Pool", "", 4, 1500.0, 1000 });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Details", "ImageUrl", "Occupancy", "Rate", "Sqft" },
                values: new object[] { new DateTime(2023, 9, 21, 21, 49, 40, 312, DateTimeKind.Local).AddTicks(5799), "This is a Premium Villa with exquisite taste", "", 2, 2000.0, 1560 });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Details", "ImageUrl", "Occupancy", "Rate", "Sqft" },
                values: new object[] { new DateTime(2023, 9, 21, 21, 49, 40, 312, DateTimeKind.Local).AddTicks(5801), "This is a premium villa with exquisite taste and a pool", "", 4, 4000.0, 2100 });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Details", "ImageUrl", "Rate", "Sqft" },
                values: new object[] { new DateTime(2023, 9, 21, 21, 49, 40, 312, DateTimeKind.Local).AddTicks(5803), "This is a luxuriously exqusite and lavish villa", "", 7000.0, 3600 });
        }
    }
}
