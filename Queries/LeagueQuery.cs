using Microsoft.EntityFrameworkCore;
using NetCoreGraphQlLearn.Database;
using NetCoreGraphQlLearn.Models;

namespace NetCoreGraphQlLearn.Queries
{
    public class Queries
    {

        [UseProjection]
        [UseFiltering]
        [UseSorting]
        public IQueryable<League> GetLeagues([Service] AppDb appDb)
        {
            return appDb.Leagues.Include(x => x.Teams).ThenInclude(x=>x.Players).AsQueryable();
        }

        [UseProjection]
        [UseFiltering]
        [UseSorting]
        public IQueryable<Team> GetTeams([Service] AppDb appDb)
        {
            return appDb.Teams.Include(x => x.League).Include(x => x.Players).AsQueryable();
        }


        [UseProjection]
        [UseFiltering]
        [UseSorting]
        public IQueryable<Player> GetPlayers([Service] AppDb appDb)
        {
            return appDb.Players.Include(x => x.Team).ThenInclude(x => x.League).AsQueryable();
        }
    }
}
