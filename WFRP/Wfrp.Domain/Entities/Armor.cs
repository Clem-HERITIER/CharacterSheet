using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wfrp.Domain.Entities
{
    public class Armor : Item
    {
        public string Location { get; set; } = string.Empty; // e.g., Head, Body
        public int ArmorPoints { get; set; }
    }
}
