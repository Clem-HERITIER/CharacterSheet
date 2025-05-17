namespace Wfrp.Domain.Entities
{
    public class CareerLevelTalent
    {
        public Guid CareerLevelId { get; set; }
        public CareerLevel CareerLevel { get; set; }

        public Guid TalentId { get; set; }
        public Talent Talent { get; set; }

        public bool IsOptional { get; set; } = false;

        public int DisplayOrder { get; set; }
    }
}
