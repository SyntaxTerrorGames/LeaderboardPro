using System.Collections.Generic;

namespace LeaderboardPro.Data
{
    public class Player
    {
        public long Id { get; set; }
        public string AspNetUsersId { get; set; }
        public string AvatarFilename { get; set; }
        public long AchievementScoreTotal { get; set; }

        public ICollection<Score> Scores { get; set; }
        public ICollection<Game> Games { get; set; }
        public ICollection<Achievement> Achievements { get; set; }
        public ICollection<TeamPlayer> TeamPlayers { get; set; }
    }
}
