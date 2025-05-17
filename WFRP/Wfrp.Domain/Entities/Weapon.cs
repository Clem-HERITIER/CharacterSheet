using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wfrp.Domain.Entities
{
    public class Weapon : Item
    {
        public int Damage { get; set; }
        public string Reach { get; set; } = string.Empty;
        public string Qualities { get; set; } = string.Empty;
        public string Flaws { get; set; } = string.Empty;
    }
}
