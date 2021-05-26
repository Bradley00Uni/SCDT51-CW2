using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ITS_Support.Data.Migrations
{
    public partial class EditCampus : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UserCreated",
                table: "Campuses",
                newName: "Creator");

            migrationBuilder.AddColumn<DateTime>(
                name: "createdAt",
                table: "Campuses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "lastEditied",
                table: "Campuses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "createdAt",
                table: "Campuses");

            migrationBuilder.DropColumn(
                name: "lastEditied",
                table: "Campuses");

            migrationBuilder.RenameColumn(
                name: "Creator",
                table: "Campuses",
                newName: "UserCreated");
        }
    }
}
