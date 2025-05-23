namespace Wfrp.Domain.Entities
{
    public class SkillSpecialization
    {
        public int Id { get; set; }

        public int SkillId { get; set; }
        public Skill Skill { get; set; }

        public string Name { get; set; } = string.Empty;
    }
}
