namespace Wfrp.Domain.Entities
{
    public class CharacterTalent
    {
        public int CharacterId { get; set; }
        public Character Character { get; set; }

        public int TalentId { get; set; }
        public Talent Talent { get; set; }

        public int Rank { get; set; } = 1;
        public int AcquiredAtLevel { get; set; }
    }
}
