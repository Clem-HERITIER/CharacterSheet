namespace Wfrp.Domain.Entities
{
    public class Weapon : Item
    {
        public string WeaponType { get; set; } = "Corps à corps";
        public string Damage { get; set; } = string.Empty;
        public string Reach { get; set; } = string.Empty; 
        public string Qualities { get; set; } = string.Empty; 
        public string Flaws { get; set; } = string.Empty;
    }
}
