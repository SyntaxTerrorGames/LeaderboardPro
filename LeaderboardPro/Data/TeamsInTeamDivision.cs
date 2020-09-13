using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeaderboardPro.Data
{
    public class TeamsInTeamDivision
    {
        public long Id { get; set; }
        public string TeamId { get; set; }
        public long TeamDivisionId { get; set; }

        public Team Team { get; set; }
        public TeamDivision TeamDivision {get;set;}
    }
}
