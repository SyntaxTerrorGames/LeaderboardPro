using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LeaderboardPro.Migrations
{
    public partial class AddedLeagues : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Leagues",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true),
                    SortDivisionsAscending = table.Column<bool>(nullable: false),
                    NoOfPromotedPlayers = table.Column<int>(nullable: false),
                    NoOfRelegatedPlayers = table.Column<int>(nullable: false),
                    PointsPerWin = table.Column<int>(nullable: false),
                    PointsPerTie = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Leagues", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TeamLeagues",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true),
                    SortDivisionsAscending = table.Column<bool>(nullable: false),
                    NoOfPromotedTeams = table.Column<int>(nullable: false),
                    NoOfRelegatedTeams = table.Column<int>(nullable: false),
                    PointsPerWin = table.Column<int>(nullable: false),
                    PointsPerTie = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeamLeagues", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TournamentTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TournamentTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Divisions",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DivisionNo = table.Column<int>(nullable: false),
                    LeagueId = table.Column<long>(nullable: false),
                    MaxPlayers = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Divisions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Divisions_Leagues_LeagueId",
                        column: x => x.LeagueId,
                        principalTable: "Leagues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TeamDivisions",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DivisionNo = table.Column<int>(nullable: false),
                    LeagueId = table.Column<long>(nullable: false),
                    MaxTeams = table.Column<int>(nullable: false),
                    TeamLeagueId = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeamDivisions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TeamDivisions_TeamLeagues_TeamLeagueId",
                        column: x => x.TeamLeagueId,
                        principalTable: "TeamLeagues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Tournaments",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TournamentTitle = table.Column<string>(nullable: true),
                    TournamentTypeId = table.Column<int>(nullable: false),
                    TournamentStartDate = table.Column<DateTime>(nullable: false),
                    TournamentEndDate = table.Column<DateTime>(nullable: false),
                    GameModeId = table.Column<string>(nullable: true),
                    GameModeId1 = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tournaments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tournaments_GameModes_GameModeId1",
                        column: x => x.GameModeId1,
                        principalTable: "GameModes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tournaments_TournamentTypes_TournamentTypeId",
                        column: x => x.TournamentTypeId,
                        principalTable: "TournamentTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PlayersInDivisions",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlayerId = table.Column<long>(nullable: false),
                    DivisionId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlayersInDivisions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PlayersInDivisions_Divisions_DivisionId",
                        column: x => x.DivisionId,
                        principalTable: "Divisions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PlayersInDivisions_Players_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "Players",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TeamsInTeamDivisions",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TeamId = table.Column<string>(nullable: true),
                    TeamDivisionId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeamsInTeamDivisions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TeamsInTeamDivisions_TeamDivisions_TeamDivisionId",
                        column: x => x.TeamDivisionId,
                        principalTable: "TeamDivisions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TeamsInTeamDivisions_Teams_TeamId",
                        column: x => x.TeamId,
                        principalTable: "Teams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Divisions_LeagueId",
                table: "Divisions",
                column: "LeagueId");

            migrationBuilder.CreateIndex(
                name: "IX_PlayersInDivisions_DivisionId",
                table: "PlayersInDivisions",
                column: "DivisionId");

            migrationBuilder.CreateIndex(
                name: "IX_PlayersInDivisions_PlayerId",
                table: "PlayersInDivisions",
                column: "PlayerId");

            migrationBuilder.CreateIndex(
                name: "IX_TeamDivisions_TeamLeagueId",
                table: "TeamDivisions",
                column: "TeamLeagueId");

            migrationBuilder.CreateIndex(
                name: "IX_TeamsInTeamDivisions_TeamDivisionId",
                table: "TeamsInTeamDivisions",
                column: "TeamDivisionId");

            migrationBuilder.CreateIndex(
                name: "IX_TeamsInTeamDivisions_TeamId",
                table: "TeamsInTeamDivisions",
                column: "TeamId");

            migrationBuilder.CreateIndex(
                name: "IX_Tournaments_GameModeId1",
                table: "Tournaments",
                column: "GameModeId1");

            migrationBuilder.CreateIndex(
                name: "IX_Tournaments_TournamentTypeId",
                table: "Tournaments",
                column: "TournamentTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PlayersInDivisions");

            migrationBuilder.DropTable(
                name: "TeamsInTeamDivisions");

            migrationBuilder.DropTable(
                name: "Tournaments");

            migrationBuilder.DropTable(
                name: "Divisions");

            migrationBuilder.DropTable(
                name: "TeamDivisions");

            migrationBuilder.DropTable(
                name: "TournamentTypes");

            migrationBuilder.DropTable(
                name: "Leagues");

            migrationBuilder.DropTable(
                name: "TeamLeagues");
        }
    }
}
