using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace Wfrp.Domain.Entities
{
    public class Character
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;

        public Guid RaceId { get; set; }
        public Race Race { get; set; }

        public Characteristics InitialCharacteristics { get; set; } = new();
        public Characteristics AdvancesCharacteristics { get; set; } = new();

        public List<CharacterCareer> Careers { get; set; } = new();
        public List<CharacterSkill> Skills { get; set; } = new();
        public List<CharacterTalent> Talents { get; set; } = new();
        public List<CharacterItem> Inventory { get; set; } = new();

        public int FatePoints { get; set; }
        public int ResiliencePoints { get; set; }
    }
}
