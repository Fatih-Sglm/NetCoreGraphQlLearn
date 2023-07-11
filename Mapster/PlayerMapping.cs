using Mapster;
using NetCoreGraphQlLearn.Entities;
using NetCoreGraphQlLearn.ViewModels;

namespace NetCoreGraphQlLearn.Mapster
{
    public static class PlayerMapping
    {
        public static void ListPlayerMapping(this TypeAdapterConfig config)
        {
            config.NewConfig<Player, ListPlayerViewModel>()
                .Map(dest => dest.TeamName, src => src.Team.Name)
                .Map(dest => dest.LeagueName, src => src.Team.League.Name);
        }
    }
}
