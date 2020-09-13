using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeaderboardPro.Data
{
    public class PlayersInDivision
    {
        public long Id { get; set; }
        public long PlayerId { get; set; }
        public long DivisionId { get; set; }

        public Player Player { get; set; }
        public Division Division { get; set; }
    }
}
