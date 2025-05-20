using Wfrp.Shared.Enums;

namespace Wfrp.Domain.Entities
{
    public abstract class Item
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;

        public Availability Availability { get; set; } = Availability.Common;
        public List<ItemQuality>? Qualities { get; set; } = null;
        public List<ItemFlaw>? Flaws { get; set; } = null;
        public double Weight { get; set; } = 0;
        public string Value { get; set; } = string.Empty; 
    }
}
