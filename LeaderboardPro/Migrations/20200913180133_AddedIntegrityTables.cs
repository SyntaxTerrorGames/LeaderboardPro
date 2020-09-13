using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LeaderboardPro.Migrations
{
    public partial class AddedIntegrityTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FriendRequests",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReceivingPlayerId = table.Column<long>(nullable: false),
                    RequestingPlayerId = table.Column<long>(nullable: false),
                    DateRequested = table.Column<DateTime>(nullable: false),
                    DateExpired = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FriendRequests", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Friends",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AcceptedPlayerId = table.Column<long>(nullable: false),
                    DateAccepted = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Friends", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GameBans",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GameId = table.Column<string>(nullable: true),
                    PlayerId = table.Column<long>(nullable: false),
                    DateOfBan = table.Column<DateTime>(nullable: false),
                    ReasonForBan = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GameBans", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GameBans_Games_GameId",
                        column: x => x.GameId,
                        principalTable: "Games",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_GameBans_Players_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "Players",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GameSuspensions",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GameId = table.Column<string>(nullable: true),
                    PlayerId = table.Column<long>(nullable: false),
                    DateOfSuspension = table.Column<DateTime>(nullable: false),
                    DateOfReinstatement = table.Column<DateTime>(nullable: false),
                    ReasonForSuspension = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GameSuspensions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PlayerBlocks",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlayerId = table.Column<long>(nullable: false),
                    PlayerToBlockId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlayerBlocks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PlayerBlocks_Players_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "Players",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_GameBans_GameId",
                table: "GameBans",
                column: "GameId");

            migrationBuilder.CreateIndex(
                name: "IX_GameBans_PlayerId",
                table: "GameBans",
                column: "PlayerId");

            migrationBuilder.CreateIndex(
                name: "IX_PlayerBlocks_PlayerId",
                table: "PlayerBlocks",
                column: "PlayerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FriendRequests");

            migrationBuilder.DropTable(
                name: "Friends");

            migrationBuilder.DropTable(
                name: "GameBans");

            migrationBuilder.DropTable(
                name: "GameSuspensions");

            migrationBuilder.DropTable(
                name: "PlayerBlocks");
        }
    }
}
