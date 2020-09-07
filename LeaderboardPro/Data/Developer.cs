using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeaderboardPro.Data
{
    public class Developer
    {
        public string Id { get; set; }
        public string CompanyName { get; set; }

        public List<Game> Games { get; set; }
    }
}
