using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaBoxWeb.Models
{
    public class Restaurant
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<int> LocationIDs { get; set; }
        public List<Location> locations { get; set; }
    }
}
