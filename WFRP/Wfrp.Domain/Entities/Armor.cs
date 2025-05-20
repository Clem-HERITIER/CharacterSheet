namespace Wfrp.Domain.Entities
{
    public class Armor : Item
    {
        public string Location { get; set; } = string.Empty;
        public int ArmorPoints { get; set; }
    }
}
