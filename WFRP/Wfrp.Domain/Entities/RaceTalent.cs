namespace Wfrp.Domain.Entities
{
    public class RaceTalent
    {
        public int RaceId { get; set; }
        public Race Race { get; set; }

        public int TalentId { get; set; }
        public Talent Talent { get; set; }

        public bool IsOptional { get; set; } = false;

        public int DisplayOrder { get; set; }
    }
}
