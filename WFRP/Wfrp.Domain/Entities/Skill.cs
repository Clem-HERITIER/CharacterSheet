namespace Wfrp.Domain.Entities
{
    public class Skill
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;

        public CharacteristicType Characteristic { get; set; }

        public string? Specialization { get; set; }

        public bool IsAdvanced { get; set; } = false;
    }
}