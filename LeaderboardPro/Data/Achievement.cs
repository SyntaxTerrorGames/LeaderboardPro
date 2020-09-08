using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeaderboardPro.Data
{
    public class Achievement
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int PointsValue { get; set; }
        public long AchievementIconId { get; set; }

        public AchievementIcon AchievementIcon { get; set; }
    }
}
