using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeaderboardPro.Data
{
    public class KnockOut
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string GameModeId { get; set; }
        public DateTime TournamentStartDate { get; set; }
        public int NoOfRounds { get; set; }
        public int MaxPlayersPerRound { get; set; }

        public GameMode GameMode { get; set; }
    }
}
