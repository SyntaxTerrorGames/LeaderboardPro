using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeaderboardPro.Data
{
    public class TeamLeague
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public bool SortDivisionsAscending { get; set; }
        public int NoOfPromotedTeams { get; set; }
        public int NoOfRelegatedTeams { get; set; }
        public int PointsPerWin { get; set; }
        public int PointsPerTie { get; set; }
    }
}
