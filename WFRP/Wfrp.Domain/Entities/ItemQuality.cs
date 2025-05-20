namespace Wfrp.Domain.Entities
{
    public class ItemQuality
    {
        public int ItemId { get; set; }
        public Item Item { get; set; } = null!;

        public int QualityId { get; set; }
        public Quality Quality { get; set; } = null!;
    }
}
