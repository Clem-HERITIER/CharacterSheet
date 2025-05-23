namespace Wfrp.Domain.Entities
{
    public class CareerClass
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;

        public List<CareerClassItem>? ClassTrapping { get; set; };

        public List<Career> Careers { get; set; } = new();
    }
}
