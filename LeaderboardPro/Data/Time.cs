using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeaderboardPro.Data
{
    public class Time
    {
        public long Id { get; set; }
        public DateTime Value { get; set; }
        public DateTime DateSubmitted { get; set; }
        public string GameId { get; set; }
        public string GameKeyId { get; set; }
        public long PlayerId { get; set; }

        public Game Game { get; set; }
        public GameKey GameKey { get; set; }
        public Player Player { get; set; }
    }
}
