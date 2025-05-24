namespace Wfrp.Domain.Entities
{
    public class Talent
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string MaximumLevel { get; set; } = string.Empty;
        public string? TestType { get; set; }
        public string Description { get; set; } = string.Empty;
    }
}
