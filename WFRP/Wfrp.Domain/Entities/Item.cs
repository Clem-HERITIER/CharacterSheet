namespace Wfrp.Domain.Entities
{
    public abstract class Item
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;

        public Availability Availability { get; set; } = Availability.Common;
        public double Weight { get; set; } = 0;
        public int Value { get; set; } = 0; 
    }
}
