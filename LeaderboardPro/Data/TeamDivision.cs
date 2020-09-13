using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeaderboardPro.Data
{
    public class TeamDivision
    {
        public long Id { get; set; }
        public int DivisionNo { get; set; }
        public long LeagueId { get; set; }
        public int MaxTeams { get; set; }

        public TeamLeague TeamLeague { get; set; }
    }
}
