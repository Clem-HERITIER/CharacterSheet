namespace Wfrp.Domain.Entities
{
    public class CareerItem
    {
        public int CareerId { get; set; }
        public Career Career { get; set; }

        public int ItemId { get; set; }
        public Item Item { get; set; }

        public int Quantity { get; set; } = 1;
        public string? Notes { get; set; }
    }
}
