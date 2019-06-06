using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaBoxWeb.Models
{
    public class User
    {
        [DisplayName("ID")]
        public int UserId { get; set; }
        [DisplayName("Username")]
        [Required(ErrorMessage = "Username is required")]
        [StringLength(20, MinimumLength = 4, ErrorMessage = "Must be between 4 and 20 characters")]
        public string Username { get; set; }
        [DisplayName("First Name")]
        public string FirstName { get; set; }
        [DisplayName("Last Name")]
        public string LastName { get; set; }
        [DisplayName("Password")]
        [Required(ErrorMessage = "Password is required")]
        [DataType(DataType.Password)]
        [StringLength(20, MinimumLength = 4, ErrorMessage = "Must be between 4 and 20 characters")]
        public string Pass { get; set; }
        [DisplayName("City")]
        [Required(ErrorMessage = "City is required")]
        public string City { get; set; }
        [DisplayName("Email")]
        public string Email { get; set; }

        public List<int> PizzaIDs { get; set; }
        public List<int> OrderIDs { get; set; }
        public List<int> LocationIDs { get; set; }

        public List<Pizza> Pizzas { get; set; }
        public List<Order> Orders { get; set; }
        public List<Location> Locations { get; set; }
    }
}
