using Microsoft.EntityFrameworkCore.Migrations;

namespace ITS_Support.Data.Migrations
{
    public partial class assetroomfix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Campus",
                table: "AssetModel");

            migrationBuilder.DropColumn(
                name: "Room",
                table: "AssetModel");

            migrationBuilder.AddColumn<int>(
                name: "RoomId",
                table: "AssetModel",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_AssetModel_RoomId",
                table: "AssetModel",
                column: "RoomId");

            migrationBuilder.AddForeignKey(
                name: "FK_AssetModel_Rooms_RoomId",
                table: "AssetModel",
                column: "RoomId",
                principalTable: "Rooms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AssetModel_Rooms_RoomId",
                table: "AssetModel");

            migrationBuilder.DropIndex(
                name: "IX_AssetModel_RoomId",
                table: "AssetModel");

            migrationBuilder.DropColumn(
                name: "RoomId",
                table: "AssetModel");

            migrationBuilder.AddColumn<string>(
                name: "Campus",
                table: "AssetModel",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Room",
                table: "AssetModel",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
