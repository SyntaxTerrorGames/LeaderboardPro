﻿using System.Collections.Generic;

namespace LeaderboardPro.Data
{
    public class Developer
    {
        public string Id { get; set; }
        public string CompanyName { get; set; }
        public string AspNetUsersId { get; set; }

        public List<Game> Games { get; set; }
    }
}
