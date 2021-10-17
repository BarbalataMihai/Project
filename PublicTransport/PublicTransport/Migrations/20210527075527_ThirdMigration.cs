using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PublicTransport.Migrations
{
    public partial class ThirdMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Valabilty",
                table: "Card");

            migrationBuilder.AddColumn<string>(
                name: "CVC",
                table: "Card",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Expiration",
                table: "Card",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Number",
                table: "Card",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CVC",
                table: "Card");

            migrationBuilder.DropColumn(
                name: "Expiration",
                table: "Card");

            migrationBuilder.DropColumn(
                name: "Number",
                table: "Card");

            migrationBuilder.AddColumn<DateTime>(
                name: "Valabilty",
                table: "Card",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
