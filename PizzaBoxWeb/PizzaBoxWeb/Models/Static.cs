using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaBoxWeb.Models
{
    public static class Static
    {
        public static User LoggedInUser = new User();
        public static Order currentOrder = new Order();
        public static Pizza currentPizza = new Pizza();
        public static Location currentLocation = new Location();
    }
}
