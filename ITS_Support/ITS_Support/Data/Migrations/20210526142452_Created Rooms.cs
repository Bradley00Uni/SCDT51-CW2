using Microsoft.EntityFrameworkCore.Migrations;

namespace ITS_Support.Data.Migrations
{
    public partial class CreatedRooms : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Campus",
                table: "Campuses",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Campuses",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Campus",
                table: "Campuses");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Campuses");
        }
    }
}
