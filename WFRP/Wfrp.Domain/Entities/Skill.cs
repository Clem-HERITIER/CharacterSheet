namespace Wfrp.Domain.Entities
{
    public class Skill
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;

        public string? ShortDescription { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;

        public CharacteristicType Characteristic { get; set; }

        public bool IsGrouped { get; set; } = false;
        public string? Specialization { get; set; }

        public bool IsAdvanced { get; set; } = false;
    }
}