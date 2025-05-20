namespace Wfrp.Domain.Entities
{
    public class CharacterCareer
    {
        public int CharacterId { get; set; }
        public Character Character { get; set; }
        public int CareerId { get; set; }
        public Career Career { get; set; }
        public int Level { get; set; }
    }
}
