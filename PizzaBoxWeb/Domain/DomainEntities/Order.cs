using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.DomainEntities
{
    public class Order
    {
        public int OrderId { get; set; }
        public DateTime? OrderTime { get; set; }
        public int UserID { get; set; }
        public int LocationID { get; set; }
        public List<int> Pizzas { get; set; }
    }
}

