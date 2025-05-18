namespace Wfrp.Domain.Entities
{
    public class CharacterSkill
    {
        public Guid CharacterId { get; set; }
        public Character Character { get; set; }
        public Guid SkillId { get; set; }
        public Skill Skill { get; set; }
        public int AcquiredAtLevel { get; set; }
        public int XPSpent { get; set; }
    }
}
