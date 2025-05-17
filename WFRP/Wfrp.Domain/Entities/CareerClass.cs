using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wfrp.Domain.Entities
{
    public class CareerClass
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;

        public List<Career> Careers { get; set; } = new();
    }
}
