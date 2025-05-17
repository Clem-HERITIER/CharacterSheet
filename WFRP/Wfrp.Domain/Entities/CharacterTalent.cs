using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wfrp.Domain.Entities
{
    public class CharacterTalent
    {
        public Guid CharacterId { get; set; }
        public Character Character { get; set; }
        public Guid TalentId { get; set; }
        public Talent Talent { get; set; }
        public int AcquiredAtLevel { get; set; }
    }
}
