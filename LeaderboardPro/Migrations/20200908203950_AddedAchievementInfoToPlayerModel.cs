using Microsoft.EntityFrameworkCore.Migrations;

namespace LeaderboardPro.Migrations
{
    public partial class AddedAchievementInfoToPlayerModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "AchievementScoreTotal",
                table: "Players",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "PlayerId",
                table: "Achievements",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Achievements_PlayerId",
                table: "Achievements",
                column: "PlayerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Achievements_Players_PlayerId",
                table: "Achievements",
                column: "PlayerId",
                principalTable: "Players",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Achievements_Players_PlayerId",
                table: "Achievements");

            migrationBuilder.DropIndex(
                name: "IX_Achievements_PlayerId",
                table: "Achievements");

            migrationBuilder.DropColumn(
                name: "AchievementScoreTotal",
                table: "Players");

            migrationBuilder.DropColumn(
                name: "PlayerId",
                table: "Achievements");
        }
    }
}
