namespace Wfrp.Domain.Entities
{
    public class Weapon : Item
    {
        public WeaponType WeaponType { get; set; } = WeaponType.UNKNOWN;
        public string Damage { get; set; } = string.Empty;
        public Reach Reach { get; set; } = Reach.Average; 
        public List<WeaponQuality>? Qualities { get; set; } = null;
        public List<WeaponFlaw>? Flaws { get; set; } = null;
    }
}
