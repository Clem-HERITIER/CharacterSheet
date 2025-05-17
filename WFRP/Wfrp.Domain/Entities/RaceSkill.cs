namespace Wfrp.Domain.Entities
{
    public class RaceSkill
    {
        public Guid RaceId { get; set; }
        public Race Race { get; set; }

        public Guid SkillId { get; set; }
        public Skill Skill { get; set; }

        public int InitialLevel { get; set; } = 0;
    }
}
