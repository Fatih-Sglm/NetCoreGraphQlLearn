using Bogus;
using NetCoreGraphQlLearn.Models;

namespace NetCoreGraphQlLearn.Extensions
{
    public static class CreateFakedata
    {
        public static List<League> GenerateLeagues(int count)
        {
            var ids = 1;
            var leagues = new Faker<League>()
                .RuleFor(l => l.Id, f => ids++)
                .RuleFor(l => l.Name, f => f.Company.CompanyName())
                .RuleFor(l => l.flagLink, f => f.Internet.Url())
                .Generate(count);

            return leagues;
        }
        public static List<Team> GenerateTeams(int count, List<League> leagues)
        {
            var ids = 1;
            var teams = new Faker<Team>()
                .RuleFor(t => t.Id, f => ids++)
                .RuleFor(t => t.Name, f => f.Company.CompanyName())
                .RuleFor(t => t.TeamColors, f => f.Commerce.Color())
                .RuleFor(t => t.iconLink, f => f.Internet.Url())
                .RuleFor(t => t.LeagueId, f => f.PickRandom(leagues).Id)
                .Generate(count);

            return teams;
        }

        public static List<Player> GeneratePlayers(int count, List<Team> teams)
        {
            var ids = 1;
            var players = new Faker<Player>()
                .RuleFor(p => p.Id, f => ids++)
                .RuleFor(p => p.Name, f => f.Name.FullName())
                .RuleFor(p => p.Age, f => f.Random.Number(18, 40))
                .RuleFor(p => p.AnnualSalary, f => f.Finance.Amount(10000, 1000000))
                .RuleFor(p => p.TeamId, f => f.PickRandom(teams).Id)
                .Generate(count);

            return players;
        }



    }
}
