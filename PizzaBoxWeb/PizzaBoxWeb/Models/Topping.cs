using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaBoxWeb.Models
{
    public class Topping
    {
        [DisplayName("ID")]
        public int ToppingId { get; set; }
        [DisplayName("Name")]
        [Required(ErrorMessage = "Name is required")]
        public string ToppingName { get; set; }
        [DisplayName("Price")]
        [Required(ErrorMessage = "Price is required")]
        public double? Price { get; set; }
    }
}
