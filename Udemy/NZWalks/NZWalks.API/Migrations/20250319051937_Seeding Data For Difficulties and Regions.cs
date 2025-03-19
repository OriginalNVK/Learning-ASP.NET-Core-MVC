using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NZWalks.API.Migrations
{
    /// <inheritdoc />
    public partial class SeedingDataForDifficultiesandRegions : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Difficulties",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("0016d473-a860-4f6f-8fbf-2c3757ba01f2"), "Hard" },
                    { new Guid("7de173ce-0945-4eba-82c1-c9b32e020caa"), "Medium" },
                    { new Guid("e5880302-5f64-4bed-be75-7d0e7ed8e245"), "Easy" }
                });

            migrationBuilder.InsertData(
                table: "Regions",
                columns: new[] { "Id", "Code", "Name", "RegionImageUrl" },
                values: new object[,]
                {
                    { new Guid("63310c5b-a26c-4f90-b8a6-5d2911b07f74"), "NVK01", "DakLak", "Daklak.jpg" },
                    { new Guid("85307016-8c38-4197-82c8-943714d45354"), "NVK02", "DaNang", "Danang.jpg" },
                    { new Guid("c4b20e04-651a-4a51-82a5-aded128f062a"), "NVK04", "VungTau", "Vungtau.jpg" },
                    { new Guid("d7af3233-58f9-40d0-8e60-6850918bc277"), "NVK03", "SaiGon", "Saigon.jpg" },
                    { new Guid("fb581494-3eb5-44e4-b220-3849c1a99bfd"), "NVK05", "LamDong", "Dalat.jpg" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Difficulties",
                keyColumn: "Id",
                keyValue: new Guid("0016d473-a860-4f6f-8fbf-2c3757ba01f2"));

            migrationBuilder.DeleteData(
                table: "Difficulties",
                keyColumn: "Id",
                keyValue: new Guid("7de173ce-0945-4eba-82c1-c9b32e020caa"));

            migrationBuilder.DeleteData(
                table: "Difficulties",
                keyColumn: "Id",
                keyValue: new Guid("e5880302-5f64-4bed-be75-7d0e7ed8e245"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("63310c5b-a26c-4f90-b8a6-5d2911b07f74"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("85307016-8c38-4197-82c8-943714d45354"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("c4b20e04-651a-4a51-82a5-aded128f062a"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("d7af3233-58f9-40d0-8e60-6850918bc277"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("fb581494-3eb5-44e4-b220-3849c1a99bfd"));
        }
    }
}
