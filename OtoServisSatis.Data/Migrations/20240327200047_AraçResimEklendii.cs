using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OtoServisSatis.Data.Migrations
{
    /// <inheritdoc />
    public partial class AraçResimEklendii : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Resim10",
                table: "Araclar",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Resim11",
                table: "Araclar",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Resim12",
                table: "Araclar",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Resim13",
                table: "Araclar",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Resim14",
                table: "Araclar",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Resim4",
                table: "Araclar",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Resim5",
                table: "Araclar",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Resim6",
                table: "Araclar",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Resim7",
                table: "Araclar",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Resim8",
                table: "Araclar",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Resim9",
                table: "Araclar",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Kullanicilar",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EklenmeTarihi", "UserGuid" },
                values: new object[] { new DateTime(2024, 3, 27, 23, 0, 47, 453, DateTimeKind.Local).AddTicks(9427), new Guid("92876b80-4a50-45d6-bab0-5dc0e93016ff") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Resim10",
                table: "Araclar");

            migrationBuilder.DropColumn(
                name: "Resim11",
                table: "Araclar");

            migrationBuilder.DropColumn(
                name: "Resim12",
                table: "Araclar");

            migrationBuilder.DropColumn(
                name: "Resim13",
                table: "Araclar");

            migrationBuilder.DropColumn(
                name: "Resim14",
                table: "Araclar");

            migrationBuilder.DropColumn(
                name: "Resim4",
                table: "Araclar");

            migrationBuilder.DropColumn(
                name: "Resim5",
                table: "Araclar");

            migrationBuilder.DropColumn(
                name: "Resim6",
                table: "Araclar");

            migrationBuilder.DropColumn(
                name: "Resim7",
                table: "Araclar");

            migrationBuilder.DropColumn(
                name: "Resim8",
                table: "Araclar");

            migrationBuilder.DropColumn(
                name: "Resim9",
                table: "Araclar");

            migrationBuilder.UpdateData(
                table: "Kullanicilar",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EklenmeTarihi", "UserGuid" },
                values: new object[] { new DateTime(2024, 3, 25, 21, 7, 36, 296, DateTimeKind.Local).AddTicks(3856), new Guid("d164e7c2-20d7-4962-93b8-59ad77e873e4") });
        }
    }
}
