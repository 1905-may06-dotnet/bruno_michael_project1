using System;
using System.Collections.Generic;

namespace Data.Entities
{
    public partial class Pizza
    {
        public Pizza()
        {
            PizzaTopping = new HashSet<PizzaTopping>();
        }

        public int PizzaId { get; set; }
        public string Size { get; set; }
        public int OrderId { get; set; }
        public int UserId { get; set; }

        public virtual Requisition Order { get; set; }
        public virtual Person User { get; set; }
        public virtual ICollection<PizzaTopping> PizzaTopping { get; set; }
    }
}
