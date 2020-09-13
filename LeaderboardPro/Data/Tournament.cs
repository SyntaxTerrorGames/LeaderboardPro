using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeaderboardPro.Data
{
    public class Tournament
    {
        public long Id { get; set; }
        public string TournamentTitle { get; set; }
        public int TournamentTypeId { get; set; }
        public DateTime TournamentStartDate { get; set; }
        public DateTime TournamentEndDate { get; set; }
        public string GameModeId { get; set; }

        public TournamentType TournamentType { get; set; }
        public GameMode GameMode { get; set; }
    }
}
