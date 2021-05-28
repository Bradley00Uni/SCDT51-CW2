using Microsoft.EntityFrameworkCore.Migrations;

namespace ITS_Support.Data.Migrations
{
    public partial class DatabaseforGeneralTicketsUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "GeneralTickets");

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "UpdateModel",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "UpdateModel");

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "GeneralTickets",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
