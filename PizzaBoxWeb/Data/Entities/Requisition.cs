using System;
using System.Collections.Generic;

namespace Data.Entities
{
    public partial class Requisition
    {
        public Requisition()
        {
            Pizza = new HashSet<Pizza>();
        }

        public int OrderId { get; set; }
        public DateTime? OrderTime { get; set; }
        public int UserId { get; set; }
        public int LocationId { get; set; }

        public virtual StoreLocation Location { get; set; }
        public virtual Person User { get; set; }
        public virtual ICollection<Pizza> Pizza { get; set; }
    }
}
