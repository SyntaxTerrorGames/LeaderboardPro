using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeaderboardPro.Data
{
    public class GameBan
    {
        public long Id { get; set; }
        public string GameId { get; set; }
        public long PlayerId { get; set; }
        public DateTime DateOfBan { get; set; }
        public string ReasonForBan { get; set; }

        public Game Game { get; set; }
        public Player Player { get; set; }
    }
}
