namespace Wfrp.Domain.Entities
{
    public class CharacterSkill
    {
        public int CharacterId { get; set; }
        public Character Character { get; set; }

        public int SkillId { get; set; }
        public Skill Skill { get; set; }

        public int AcquiredAtLevel { get; set; }
        public int XPSpent { get; set; }

        public int? SpecializationId { get; set; }
        public SkillSpecialization? Specialization { get; set; }
    }
}
