using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.DomainEntities
{
    public class Pizza
    {
        public int PizzaId { get; set; }
        public string Size { get; set; }
        public int OrderID { get; set; }
        public int UserID { get; set; }
        public List<int> Toppings { get; set; }
    }
}
