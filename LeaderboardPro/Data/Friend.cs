using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeaderboardPro.Data
{
    public class Friend
    {
        public long Id { get; set; }
        public long AcceptedPlayerId { get; set; }
        public DateTime DateAccepted { get; set; }

        // No relation on this table as it would be awkward and probably cause issues
    }
}
