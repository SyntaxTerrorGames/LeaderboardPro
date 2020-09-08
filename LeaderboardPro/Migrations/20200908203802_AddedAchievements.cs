using Microsoft.EntityFrameworkCore.Migrations;

namespace LeaderboardPro.Migrations
{
    public partial class AddedAchievements : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AvatarFilename",
                table: "Players",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "AchievementIcons",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Filename = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AchievementIcons", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Achievements",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    PointsValue = table.Column<int>(nullable: false),
                    AchievementIconId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Achievements", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Achievements_AchievementIcons_AchievementIconId",
                        column: x => x.AchievementIconId,
                        principalTable: "AchievementIcons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Achievements_AchievementIconId",
                table: "Achievements",
                column: "AchievementIconId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Achievements");

            migrationBuilder.DropTable(
                name: "AchievementIcons");

            migrationBuilder.DropColumn(
                name: "AvatarFilename",
                table: "Players");
        }
    }
}
