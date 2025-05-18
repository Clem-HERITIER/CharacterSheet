namespace Wfrp.Domain.Entities
{
    public class Career
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public Guid CareerClassId { get; set; }
        public CareerClass CareerClass { get; set; }

        public List<CareerLevel> Levels { get; set; } = new();
    }
}
