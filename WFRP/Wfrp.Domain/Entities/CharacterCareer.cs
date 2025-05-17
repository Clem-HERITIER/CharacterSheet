using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wfrp.Domain.Entities
{
    public class CharacterCareer
    {
        public Guid CharacterId { get; set; }
        public Character Character { get; set; }
        public Guid CareerId { get; set; }
        public Career Career { get; set; }
        public int Level { get; set; }
    }
}
