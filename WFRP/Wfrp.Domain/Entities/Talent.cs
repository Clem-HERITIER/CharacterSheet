namespace Wfrp.Domain.Entities
{
    public class Talent
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;

        public string? Description { get; set; }
        public bool CanBeRanked { get; set; } = false;
    }
}
