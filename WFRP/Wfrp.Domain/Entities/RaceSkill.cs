namespace Wfrp.Domain.Entities
{
    public class RaceSkill
    {
        public int RaceId { get; set; }
        public Race Race { get; set; }

        public int SkillId { get; set; }
        public Skill Skill { get; set; }

        public int InitialLevel { get; set; } = 0;
    }
}
