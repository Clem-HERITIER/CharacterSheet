namespace Wfrp.Domain.Entities
{
    public class WeaponFlaw
    {
        public int WeaponId { get; set; }
        public Weapon Weapon { get; set; } = null!;

        public int FlawId { get; set; }
        public Flaw Flaw { get; set; } = null!;
    }
}
