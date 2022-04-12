using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WpfEFCoreDemo.Migrations
{
    public partial class m5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterTable(
                name: "StudentGroups",
                comment: "My table");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterTable(
                name: "StudentGroups",
                oldComment: "My table");
        }
    }
}
