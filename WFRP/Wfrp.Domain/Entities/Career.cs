namespace Wfrp.Domain.Entities
{
    public class Career
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Summary { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;

        public int CareerClassId { get; set; }
        public CareerClass CareerClass { get; set; }

        public List<CareerLevel> Levels { get; set; } = new();
    }
}
