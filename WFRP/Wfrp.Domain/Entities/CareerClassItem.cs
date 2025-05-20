namespace Wfrp.Domain.Entities
{
    public class CareerClassItem
    {
        public int CareerClassId { get; set; }
        public CareerClass CareerClass { get; set; }

        public int ItemId { get; set; }
        public Item Item { get; set; }

        public int Quantity { get; set; } = 1;
        public string? Notes { get; set; }
    }
}
