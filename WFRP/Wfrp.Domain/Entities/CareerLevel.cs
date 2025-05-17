using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wfrp.Domain.Entities
{
    public class CareerLevel
    {
        public Guid Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public int Level { get; set; }
        public Guid CareerId { get; set; }
        public Career Career { get; set; }

        public List<CharacteristicType> CanAdvanceCharacteristics { get; set; } = new();
    }

}
