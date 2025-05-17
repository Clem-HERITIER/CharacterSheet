namespace Wfrp.Domain.Entities
{
    public abstract class Item
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;

        public double Weight { get; set; } = 0;
        public int Value { get; set; } = 0; 
    }
}
