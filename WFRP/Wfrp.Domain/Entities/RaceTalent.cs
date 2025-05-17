namespace Wfrp.Domain.Entities
{
    public class RaceTalent
    {
        public Guid RaceId { get; set; }
        public Race Race { get; set; }

        public Guid TalentId { get; set; }
        public Talent Talent { get; set; }

        public bool IsOptional { get; set; } = false;

        public int DisplayOrder { get; set; }
    }
}
