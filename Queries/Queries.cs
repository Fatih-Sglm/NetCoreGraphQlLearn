using HotChocolate.Data;
using Mapster;
using MapsterMapper;
using Microsoft.EntityFrameworkCore;
using NetCoreGraphQlLearn.Database;
using NetCoreGraphQlLearn.Entities;
using NetCoreGraphQlLearn.ViewModels;

namespace NetCoreGraphQlLearn.Queries
{
    //public class Queries
    //{

    //    [UseProjection]
    //    [UseFiltering]
    //    [UseSorting]
    //    public IQueryable<League> GetLeagues([Service] AppDb appDb)
    //    {
    //        return appDb.Leagues.Include(x => x.Teams).ThenInclude(x=>x.Players).AsQueryable();
    //    }

    //    [UseProjection]
    //    [UseFiltering]
    //    [UseSorting]
    //    public IQueryable<Team> GetTeams([Service] AppDb appDb)
    //    {
    //        return appDb.Teams.Include(x => x.League).Include(x => x.Players).AsQueryable();
    //    }


    //    [UseProjection]
    //    [UseFiltering]
    //    [UseSorting]
    //    public IQueryable<Player> GetPlayers([Service] AppDb appDb)
    //    {
    //        return appDb.Players.Include(x => x.Team).ThenInclude(x => x.League).AsQueryable();
    //    }
    //}


    public class Queries
    {

        [UseProjection]
        [UseFiltering]
        [UseSorting]
        public async Task<IList<ListPlayerViewModel>> GetListPlayerViewModel([Service] AppDb appDb)
        {
            var playerData = await appDb.Players.Include(x => x.Team).ThenInclude(x => x.League).ToListAsync();
            List<ListPlayerViewModel> players = new();
            foreach (var player in playerData)
            {
                players.Add(new()
                {
                    Age = player.Age,
                    AnnualSalary = player.AnnualSalary,
                    Id = player.Id,
                    LeagueName = player.Team.League.Name,
                    Name = player.Name,
                    TeamName = player.Team.Name
                });
            }

            return players;
        }

        [UseProjection]
        [UseFiltering]
        [UseSorting]
        public async Task<IList<ListPlayerViewModel>> GetListPlayerViewModelWithMapper([Service] AppDb appDb , [Service]IMapper mapper)
        {

            var data =  await appDb.Players.Include(x => x.Team).ThenInclude(y=>y.League)
                .ProjectToType<ListPlayerViewModel>(mapper.Config).ToListAsync();
            return data;
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
