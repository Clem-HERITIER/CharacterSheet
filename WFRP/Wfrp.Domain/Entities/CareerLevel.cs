namespace Wfrp.Domain.Entities
{
    public class CareerLevel
    {
        public int Id { get; set; }

        public string Title { get; set; } = string.Empty;
        public int Level { get; set; } // 1 to 4

        public int CareerId { get; set; }
        public Career Career { get; set; }

        public StatusTier StatusTier { get; set; }
        public int StatusLevel { get; set; }

        public List<CharacteristicType> CanAdvanceCharacteristics { get; set; } = new();

        public List<CareerLevelSkill> Skills { get; set; } = new();
        public List<CareerLevelTalent> Talents { get; set; } = new();
    }
}
