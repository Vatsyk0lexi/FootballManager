using Microsoft.EntityFrameworkCore;
using System.Numerics;

namespace FootbalManagerAPI.Models.Entity
{
    public class FootballManagerContext : DbContext
    {
        public FootballManagerContext(DbContextOptions<FootballManagerContext> options) : base(options){ }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<Tournament> Tournaments { get; set; }
        public DbSet<Match> Matches { get; set; }
        public DbSet<News> News { get; set; }
        public DbSet<Trainer> Trainer { get; set; }
        public DbSet<TournamentTeamStatistic> TournamentTeamStatistics { get; set; }
        public DbSet<PlayerPosition> PlayerPosition { get; set; }
        public DbSet<MatchPlayerStatictic> MatchPlayerStatictics { get; set; }
        public DbSet<TournamentPlayerStatistic> TournamentPlayerStatistics { get; set; }

    }
}


