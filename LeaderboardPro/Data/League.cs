using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeaderboardPro.Data
{
    public class League
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public bool SortDivisionsAscending { get; set; }
        public int NoOfPromotedPlayers { get; set; }
        public int NoOfRelegatedPlayers { get; set; }
        public int PointsPerWin { get; set; }
        public int PointsPerTie { get; set; }

        public ICollection<Division> Divisions { get; set; }
    }
}
