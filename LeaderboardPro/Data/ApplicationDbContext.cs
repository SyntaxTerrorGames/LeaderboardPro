using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace LeaderboardPro.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<Developer> Developers { get; set; }
        public virtual DbSet<Address> Addresses { get; set; }
        public virtual DbSet<Game> Games { get; set; }
        public virtual DbSet<Mode> Modes { get; set; }
        public virtual DbSet<GameMode> GameModes { get; set; }
        public virtual DbSet<Score> Scores { get; set; }
        public virtual DbSet<Platform> Platforms { get; set; }
        public virtual DbSet<Player> Players { get; set; }
        public virtual DbSet<GameKey> GameKeys { get; set; }
        public virtual DbSet<Time> Times { get; set; }
        public virtual DbSet<Achievement> Achievements { get; set; }
        public virtual DbSet<AchievementIcon> AchievementIcons { get; set; }
        public virtual DbSet<Team> Teams { get; set; }
        public virtual DbSet<TeamPlayer> TeamPlayers { get; set; }
        public virtual DbSet<PlayerBlock> PlayerBlocks { get; set; }
        public virtual DbSet<GameSuspension> GameSuspensions { get; set; }
        public virtual DbSet<GameBan> GameBans { get; set; }
        public virtual DbSet<Friend> Friends { get; set; }
        public virtual DbSet<FriendRequest> FriendRequests { get; set; }
        public virtual DbSet<Division> Divisions { get; set; }
        public virtual DbSet<TeamDivision> TeamDivisions { get; set; }
        public virtual DbSet<League> Leagues { get; set; }
        public virtual DbSet<TeamLeague> TeamLeagues { get; set; }
        public virtual DbSet<TeamsInTeamDivision> TeamsInTeamDivisions { get; set; }
        public virtual DbSet<PlayersInDivision> PlayersInDivisions { get; set; }
        public virtual DbSet<Tournament> Tournaments { get; set; }
        public virtual DbSet<TournamentType> TournamentTypes { get; set; }
    }
}
