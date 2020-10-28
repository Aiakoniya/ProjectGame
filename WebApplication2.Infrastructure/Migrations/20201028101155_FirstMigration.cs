using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication2.Migrations
{
    public partial class FirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PlayerList",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Difficulty = table.Column<string>(nullable: true),
                    MovesId = table.Column<Guid>(nullable: false),
                    PlayerScore = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlayerList", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Movess",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    MovesNum = table.Column<int>(nullable: false),
                    PlayerId = table.Column<Guid>(nullable: false),
                    PlayerScoreID = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movess", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Movess_PlayerList_PlayerScoreID",
                        column: x => x.PlayerScoreID,
                        principalTable: "PlayerList",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Movess_PlayerScoreID",
                table: "Movess",
                column: "PlayerScoreID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movess");

            migrationBuilder.DropTable(
                name: "PlayerList");
        }
    }
}
