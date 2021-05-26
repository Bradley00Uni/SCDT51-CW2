using Microsoft.EntityFrameworkCore.Migrations;

namespace ITS_Support.Data.Migrations
{
    public partial class EditCampus2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "createdAt",
                table: "Campuses",
                newName: "CreatedAt");

            migrationBuilder.RenameColumn(
                name: "lastEditied",
                table: "Campuses",
                newName: "LastEdited");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "Campuses",
                newName: "createdAt");

            migrationBuilder.RenameColumn(
                name: "LastEdited",
                table: "Campuses",
                newName: "lastEditied");
        }
    }
}
