using System.Collections.Generic;

namespace LeaderboardPro.Data
{
    public class Mode
    {
        public long Id { get; set; }
        public string ModeName { get; set; }

        public List<GameMode> GameModes { get; set; }
    }
}
