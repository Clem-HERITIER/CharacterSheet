namespace Wfrp.Domain.Entities
{
    public class Race
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;

        public Characteristics BaseCharacteristics { get; set; } = new();

        public int Movement { get; set; }
        public int FatePoints { get; set; }
        public int ResiliencePoints { get; set; }
        public int ExtraPoints { get; set; }

        public List<RaceSkill> StartingSkills { get; set; } = new();
        public List<RaceTalent> StartingTalents { get; set; } = new();
    }
}
