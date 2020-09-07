using System.Collections.Generic;

namespace LeaderboardPro.Data
{
    public class Game
    {
        public string Id { get; set; }
        public string DeveloperId { get; set; }
        public string GameName { get; set; }

        public Developer Developer { get; set; }
        public List<GameKey> GameKey { get; set; }
        public List<GameMode> GameModes { get; set; }
    }
}
