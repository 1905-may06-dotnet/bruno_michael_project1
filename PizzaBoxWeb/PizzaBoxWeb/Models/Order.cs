using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaBoxWeb.Models
{
    public class Order
    {
        [DisplayName("ID")]
        public int OrderId { get; set; }
        [DisplayName("Order Time")]
        public DateTime? OrderTime { get; set; }
        [DisplayName("User")]
        public int UserID { get; set; }
        [DisplayName("Location")]
        public int LocationID { get; set; }
        [DisplayName("Pizzas")]
        public List<int> PizzaIDs { get; set; }

        public List<Pizza> Pizzas;
    }
}
