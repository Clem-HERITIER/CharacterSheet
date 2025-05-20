namespace Wfrp.Domain.Entities
{
    public class CareerLevelTalent
    {
        public int CareerLevelId { get; set; }
        public CareerLevel CareerLevel { get; set; }

        public int TalentId { get; set; }
        public Talent Talent { get; set; }

        public bool IsOptional { get; set; } = false;

        public int DisplayOrder { get; set; }
    }
}
