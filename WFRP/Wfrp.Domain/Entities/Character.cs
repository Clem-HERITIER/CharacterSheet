using System.ComponentModel.DataAnnotations.Schema;

namespace Wfrp.Domain.Entities
{
    public class Character
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int Age { get; set; }
        public int Height { get; set; } // in cm
        public string EyeColor { get; set; } = string.Empty;
        public string HairColor { get; set; } = string.Empty;
        public int FatePoints { get; set; }
        public int ResiliencePoints { get; set; }
        public int Wounds { get; set; }
        public string Description { get; set; } = string.Empty;
        public string ShortTermAmbition { get; set; } = string.Empty;
        public string LongTermAmbition { get; set; } = string.Empty;
        public string Psychology { get; set; } = string.Empty;

        public int RaceId { get; set; }
        public Race Race { get; set; }

        [NotMapped]
        public int Movement => Race?.Movement ?? 4;

        public Characteristics InitialCharacteristics { get; set; } = new();
        public Characteristics AdvancesCharacteristics { get; set; } = new();

        [NotMapped]
        public Characteristics CurrentCharacteristics { get; set; } = new();

        public int? CurrentCareerId { get; set; } 
        public Career? CurrentCareer { get; set; }
        public int CareerLevel { get; set; } // Level 1 to 4

        public List<CharacterCareer> CareerHistory { get; set; } = new();
        public List<CharacterSkill> Skills { get; set; } = new();
        public List<CharacterTalent> Talents { get; set; } = new();
        public List<CharacterItem> Inventory { get; set; } = new();

        public int ExperienceTotal { get; set; } = 0;
        public int ExperienceSpent { get; set; } = 0;

        [NotMapped]
        public int ExperienceAvailable => ExperienceTotal - ExperienceSpent;
    }
}
