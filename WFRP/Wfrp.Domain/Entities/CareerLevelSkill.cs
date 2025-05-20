namespace Wfrp.Domain.Entities
{
    public class CareerLevelSkill
    {
        public int CareerLevelId { get; set; }
        public CareerLevel CareerLevel { get; set; }

        public int SkillId { get; set; }
        public Skill Skill { get; set; }
    }
}
