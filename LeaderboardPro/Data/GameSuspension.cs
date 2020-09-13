using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeaderboardPro.Data
{
    public class GameSuspension
    {
        public long Id { get; set; }
        public string GameId { get; set; }
        public long PlayerId { get; set; }
        public DateTime DateOfSuspension { get; set; }
        public DateTime DateOfReinstatement { get; set; }
        public string ReasonForSuspension { get; set; }
    }
}
