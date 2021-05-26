using Microsoft.EntityFrameworkCore.Migrations;

namespace ITS_Support.Data.Migrations
{
    public partial class AddedCampusfk : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Campus",
                table: "Rooms");

            migrationBuilder.AddColumn<int>(
                name: "CampusId",
                table: "Rooms",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_CampusId",
                table: "Rooms",
                column: "CampusId");

            migrationBuilder.AddForeignKey(
                name: "FK_Rooms_Campuses_CampusId",
                table: "Rooms",
                column: "CampusId",
                principalTable: "Campuses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rooms_Campuses_CampusId",
                table: "Rooms");

            migrationBuilder.DropIndex(
                name: "IX_Rooms_CampusId",
                table: "Rooms");

            migrationBuilder.DropColumn(
                name: "CampusId",
                table: "Rooms");

            migrationBuilder.AddColumn<string>(
                name: "Campus",
                table: "Rooms",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
