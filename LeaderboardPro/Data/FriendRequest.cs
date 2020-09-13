using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeaderboardPro.Data
{
    public class FriendRequest
    {
        public long Id { get; set; }
        public long ReceivingPlayerId { get; set; }
        public long RequestingPlayerId { get; set; }
        public DateTime DateRequested { get; set; }
        public DateTime DateExpired { get; set; }
 
        // No relation on this table as it would be awkward and probably cause issues
        // DateExpired used to determine when a request expires. If it expires, entry is removed.
    }
}
