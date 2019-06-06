using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaBoxWeb.Models
{
    public class Location
    {
        [DisplayName("ID")]
        public int LocationId { get; set; }
        [DisplayName("Address")]
        [Required(ErrorMessage = "Address is required")]
        public string LocationAddress { get; set; }
        [DisplayName("City")]
        [Required(ErrorMessage = "City is required")]
        public string LocationCity { get; set; }
        [DisplayName("State")]
        [Required(ErrorMessage = "State is required")]
        public string LocationState { get; set; }
        [DisplayName("Zip")]
        [Required(ErrorMessage = "Zip Code is required")]
        public int? LocationZip { get; set; }
        [DisplayName("Restaurant")]
        [Required(ErrorMessage = "Restaurant is required")]
        public string Restaurant { get; set; }
    }
}
