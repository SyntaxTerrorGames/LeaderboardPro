using System.Collections.Generic;

namespace LeaderboardPro.Data
{
    public class Player
    {
        public long Id { get; set; }
        public string AspNetUsersId { get; set; }

        public List<Score> Scores { get; set; }
        public List<Game> Games { get; set; }
    }
}
