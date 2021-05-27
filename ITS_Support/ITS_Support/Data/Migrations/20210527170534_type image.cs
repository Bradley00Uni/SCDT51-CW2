using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ITS_Support.Data.Migrations
{
    public partial class typeimage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "icon",
                table: "TypeModel");

            migrationBuilder.AddColumn<byte[]>(
                name: "DisplayImage",
                table: "TypeModel",
                type: "varbinary(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DisplayImage",
                table: "TypeModel");

            migrationBuilder.AddColumn<int>(
                name: "icon",
                table: "TypeModel",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
