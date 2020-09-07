namespace LeaderboardPro.Data
{
    public class GameMode
    {
        public long Id { get; set; }
        public string GameId { get; set; }
        public long ModeId { get; set; }

        public Game Game { get; set; }
        public Mode Mode { get; set; }
    }
}
