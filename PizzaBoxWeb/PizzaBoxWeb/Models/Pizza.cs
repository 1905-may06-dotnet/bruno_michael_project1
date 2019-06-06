using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaBoxWeb.Models
{
    public class Pizza
    {
        [DisplayName("ID")]
        public int PizzaId { get; set; }
        [DisplayName("Size")]
        public string Size { get; set; }
        [DisplayName("Toppings")]
        public List<int> ToppingIDs { get; set; }
        [DisplayName("OrderID")]
        public string OrderID { get; set; }
        public int UserID { get; set; }
        public List<Order> orders;
        public List<Topping> Toppings;
    }
}
