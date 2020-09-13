using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeaderboardPro.Data
{
    public class Division
    {
        public long Id { get; set; }
        public int DivisionNo { get; set; }
        public long LeagueId { get; set; }
        public int MaxPlayers { get; set; }

        public League League { get; set; }
    }
}
