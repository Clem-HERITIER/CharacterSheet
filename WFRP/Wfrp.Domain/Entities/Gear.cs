using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wfrp.Domain.Entities
{
    public class Gear : Item
    {
        public string Description { get; set; } = string.Empty;
        public bool IsConsumable { get; set; }
    }
}
