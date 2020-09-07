﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
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
    }
}
