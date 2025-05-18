namespace Wfrp.Domain.Entities
{
    public class WeaponQuality
    {
        public int WeaponId { get; set; }
        public Weapon Weapon { get; set; } = null!;

        public int QualityId { get; set; }
        public Quality Quality { get; set; } = null!;
    }
}
