namespace Wfrp.Domain.Entities
{
    public class Weapon : Item
    {
        public WeaponType WeaponType { get; set; } = WeaponType.UNKNOWN;
        public string Damage { get; set; } = string.Empty;
        public Reach Reach { get; set; } = Reach.Average; 
        public Qualities? Qualities { get; set; } = null;
        public Flaws? Flaws { get; set; } = null;
    }
}
