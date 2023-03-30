using Microsoft.EntityFrameworkCore.Migrations;

namespace Interfata.Migrations
{
    public partial class EditMig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EditRole",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    RoleName = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EditRole", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RoleName",
                columns: table => new
                {
                    RoleName = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleName", x => x.RoleName);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EditRole");

            migrationBuilder.DropTable(
                name: "RoleName");
        }
    }
}
