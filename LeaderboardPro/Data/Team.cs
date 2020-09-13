using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeaderboardPro.Data
{
    public class Team
    {
        public string Id { get; set; }
        public string TeamName { get; set; }
        public string TeamLogoFilename { get; set; }
        public DateTime DateCreated { get; set; }

        public ICollection<TeamPlayer> TeamPlayers { get; set; }
    }
}
