namespace Wfrp.Domain.Entities
{
    public class ItemFlaw
    {
        public int ItemId { get; set; }
        public Item Item { get; set; } = null!;

        public int FlawId { get; set; }
        public Flaw Flaw { get; set; } = null!;
    }
}
