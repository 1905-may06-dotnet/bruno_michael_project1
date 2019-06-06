using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.DomainEntities
{
    public class Inventory
    {
        public int Id { get; set; }
        public int? Quantity { get; set; }
        public int LocationID { get; set; }
        public List<int> Toppings { get; set; }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
