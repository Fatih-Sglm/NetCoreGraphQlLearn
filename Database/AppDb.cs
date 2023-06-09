using Microsoft.EntityFrameworkCore;
using NetCoreGraphQlLearn.Extensions;
using NetCoreGraphQlLearn.Models;

namespace NetCoreGraphQlLearn.Database
{
    public class AppDb : DbContext
    {
        public AppDb(DbContextOptions options) : base(options)
        {
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var data = CreateFakedata.GenerateLeagues(5);
            var data2 = CreateFakedata.GenerateTeams(10, data);
            var data3 = CreateFakedata.GeneratePlayers(data2.Count*11, data2);
            modelBuilder.Entity<League>().HasData(data);
            modelBuilder.Entity<Team>().HasData(data2);
            modelBuilder.Entity<Player>().HasData(data3);
        }

        public DbSet<League> Leagues { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Player> Players { get; set; }
    }
}
