namespace Wfrp.Domain.Entities
{
    public class CareerLevelSkill
    {
        public Guid CareerLevelId { get; set; }
        public CareerLevel CareerLevel { get; set; }

        public Guid SkillId { get; set; }
        public Skill Skill { get; set; }
    }
}
