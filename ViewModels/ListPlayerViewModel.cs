using NetCoreGraphQlLearn.Entities;

namespace NetCoreGraphQlLearn.ViewModels
{
    public class ListPlayerViewModel
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Age { get; set; }
        public decimal AnnualSalary { get; set; }
        public string? TeamName { get; set; }
        public string? LeagueName { get; set; }
    }
}
