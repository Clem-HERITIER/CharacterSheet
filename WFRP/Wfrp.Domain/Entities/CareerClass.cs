namespace Wfrp.Domain.Entities
{
    public class CareerClass
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;

        public List<Career> Careers { get; set; } = new();
    }
}
