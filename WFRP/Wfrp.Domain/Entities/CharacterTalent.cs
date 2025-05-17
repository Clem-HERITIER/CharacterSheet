namespace Wfrp.Domain.Entities
{
    public class CharacterTalent
    {
        public Guid CharacterId { get; set; }
        public Character Character { get; set; }

        public Guid TalentId { get; set; }
        public Talent Talent { get; set; }

        public int Rank { get; set; } = 1;
        public int AcquiredAtLevel { get; set; }
    }
}
