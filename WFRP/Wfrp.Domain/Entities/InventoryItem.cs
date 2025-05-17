using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wfrp.Domain.Entities
{
    public class InventoryItem
    {
        public Guid CharacterId { get; set; }
        public Character Character { get; set; }
        public Guid ItemId { get; set; }
        public Item Item { get; set; }
        public int Quantity { get; set; }
        public string? Notes { get; set; }
    }
}
