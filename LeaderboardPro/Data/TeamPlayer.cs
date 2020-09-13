using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeaderboardPro.Data
{
    public class TeamPlayer
    {
        public long Id { get; set; }
        public long PlayerId { get; set; }
        public string TeamId { get; set; }

        public Player Player { get; set; }
        public Team Team { get; set; }
    }
}
