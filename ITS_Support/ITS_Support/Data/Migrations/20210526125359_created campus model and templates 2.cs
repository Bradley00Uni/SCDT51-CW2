using Microsoft.EntityFrameworkCore.Migrations;

namespace ITS_Support.Data.Migrations
{
    public partial class createdcampusmodelandtemplates2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Campus",
                table: "Campus");

            migrationBuilder.RenameTable(
                name: "Campus",
                newName: "Campuses");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Campuses",
                table: "Campuses",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Campuses",
                table: "Campuses");

            migrationBuilder.RenameTable(
                name: "Campuses",
                newName: "Campus");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Campus",
                table: "Campus",
                column: "Id");
        }
    }
}
