using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Models.Migrations
{
    public partial class UpdateDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ManageMenu",
                columns: table => new
                {
                    ManageMenuID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    MenuName = table.Column<string>(nullable: true),
                    MenuIcon = table.Column<string>(nullable: true),
                    DataName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ManageMenu", x => x.ManageMenuID);
                });

            migrationBuilder.CreateTable(
                name: "ManagerMenuChild",
                columns: table => new
                {
                    ManagerMenuChildID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    MenuChildName = table.Column<string>(nullable: true),
                    MenuChildHref = table.Column<string>(nullable: true),
                    ForMenuID = table.Column<int>(nullable: true),
                    DataName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ManagerMenuChild", x => x.ManagerMenuChildID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ManageMenu");

            migrationBuilder.DropTable(
                name: "ManagerMenuChild");
        }
    }
}
