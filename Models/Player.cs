namespace NetCoreGraphQlLearn.Models
{
    public class Player
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public decimal AnnualSalary { get; set; }
        public Team? Team { get; set; }
        public int TeamId { get; set; }
    }
}
