namespace NetCoreGraphQlLearn.Models
{
    public class Team
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string TeamColors { get; set; }
        public string iconLink { get; set; }
        public List<Player>? Players { get; set; }
        public League? League { get; set; }
        public int LeagueId { get; set; }

    }
}
