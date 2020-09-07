using System;

namespace LeaderboardPro.Data
{
    public class Score
    {
        public long Id { get; set; }
        public long Value { get; set; }
        public DateTime DateSubmitted { get; set; }
        public string GameId { get; set; }
        public string GameKeyId { get; set; }
        public long PlayerId { get; set; }

        public Game Game { get; set; }
        public GameKey GameKey { get; set; }
        public Player Player { get; set; }
    }
}
