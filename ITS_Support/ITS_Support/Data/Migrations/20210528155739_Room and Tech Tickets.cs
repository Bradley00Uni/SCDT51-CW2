using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ITS_Support.Data.Migrations
{
    public partial class RoomandTechTickets : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RoomTicketModelId",
                table: "UpdateModel",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TechnicalTicketModelId",
                table: "UpdateModel",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "RoomTickets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RaisedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RoomId = table.Column<int>(type: "int", nullable: false),
                    Issue = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ExtraDetails = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoomTickets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RoomTickets_Rooms_RoomId",
                        column: x => x.RoomId,
                        principalTable: "Rooms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TechnicalTickets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RaisedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RaisedRole = table.Column<int>(type: "int", nullable: false),
                    AssetId = table.Column<int>(type: "int", nullable: false),
                    Issue = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ExtraDetails = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TechnicalTickets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TechnicalTickets_AssetModel_AssetId",
                        column: x => x.AssetId,
                        principalTable: "AssetModel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UpdateModel_RoomTicketModelId",
                table: "UpdateModel",
                column: "RoomTicketModelId");

            migrationBuilder.CreateIndex(
                name: "IX_UpdateModel_TechnicalTicketModelId",
                table: "UpdateModel",
                column: "TechnicalTicketModelId");

            migrationBuilder.CreateIndex(
                name: "IX_RoomTickets_RoomId",
                table: "RoomTickets",
                column: "RoomId");

            migrationBuilder.CreateIndex(
                name: "IX_TechnicalTickets_AssetId",
                table: "TechnicalTickets",
                column: "AssetId");

            migrationBuilder.AddForeignKey(
                name: "FK_UpdateModel_RoomTickets_RoomTicketModelId",
                table: "UpdateModel",
                column: "RoomTicketModelId",
                principalTable: "RoomTickets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UpdateModel_TechnicalTickets_TechnicalTicketModelId",
                table: "UpdateModel",
                column: "TechnicalTicketModelId",
                principalTable: "TechnicalTickets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UpdateModel_RoomTickets_RoomTicketModelId",
                table: "UpdateModel");

            migrationBuilder.DropForeignKey(
                name: "FK_UpdateModel_TechnicalTickets_TechnicalTicketModelId",
                table: "UpdateModel");

            migrationBuilder.DropTable(
                name: "RoomTickets");

            migrationBuilder.DropTable(
                name: "TechnicalTickets");

            migrationBuilder.DropIndex(
                name: "IX_UpdateModel_RoomTicketModelId",
                table: "UpdateModel");

            migrationBuilder.DropIndex(
                name: "IX_UpdateModel_TechnicalTicketModelId",
                table: "UpdateModel");

            migrationBuilder.DropColumn(
                name: "RoomTicketModelId",
                table: "UpdateModel");

            migrationBuilder.DropColumn(
                name: "TechnicalTicketModelId",
                table: "UpdateModel");
        }
    }
}
