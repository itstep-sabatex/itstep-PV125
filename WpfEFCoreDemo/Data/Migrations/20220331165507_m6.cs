using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WpfEFCoreDemo.Migrations
{
    public partial class m6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Students",
                newName: "NameStudent");

            migrationBuilder.AlterColumn<DateTime>(
                name: "BirthDay",
                table: "Students",
                type: "TEXT",
                nullable: false,
                comment: "День народження",
                oldClrType: typeof(DateTime),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<string>(
                name: "NameStudent",
                table: "Students",
                type: "varchar(100)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "NameStudent",
                table: "Students",
                newName: "Name");

            migrationBuilder.AlterColumn<DateTime>(
                name: "BirthDay",
                table: "Students",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "TEXT",
                oldComment: "День народження");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Students",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(100)");
        }
    }
}
