using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeaderboardPro.Data
{
    public class GameKey
    {
        public string Id { get; set; }
        public string GameId { get; set; }
        public int PlatformId { get; set; }

        public Game Game { get; set; }
        public Platform Platform { get; set; }
    }
}
