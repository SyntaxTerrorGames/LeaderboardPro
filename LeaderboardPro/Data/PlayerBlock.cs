using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeaderboardPro.Data
{
    public class PlayerBlock
    {
        public long Id { get; set; }
        public long PlayerId { get; set; }
        public long PlayerToBlockId { get; set; }

        public Player Player { get; set; }
    }
}
