namespace Wfrp.Domain.Entities
{
    public class Gear : Item
    {
        public string Description { get; set; } = string.Empty;
        public bool IsConsumable { get; set; }
        public string? Effect { get; set; }
    }
}
