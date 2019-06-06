using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaBoxWeb.Models
{
    public static class Converter
    {
        public static Topping ToppingToModel(Domain.DomainEntities.Topping t)
        {
            Topping topping = new Topping();
            topping.ToppingId = t.ToppingId;
            topping.ToppingName = t.ToppingName;
            topping.Price = t.Price;
            return topping;
        }
        public static Domain.DomainEntities.Topping ToppingToDomain(Topping t)
        {
            Domain.DomainEntities.Topping topping = new Domain.DomainEntities.Topping();
            topping.ToppingId = t.ToppingId;
            topping.ToppingName = t.ToppingName;
            topping.Price = t.Price;
            return topping;
        }
        public static Pizza PizzaToModel(Domain.DomainEntities.Pizza p)
        {
            Pizza pizza = new Pizza();
            pizza.PizzaId = p.PizzaId;
            pizza.Size = p.Size;
            pizza.ToppingIDs = p.Toppings;
            pizza.UserID = Static.LoggedInUser.UserId;
            return pizza;
        }
        public static Domain.DomainEntities.Pizza PizzaToDomain(Pizza p)
        {
            Domain.DomainEntities.Pizza pizza = new Domain.DomainEntities.Pizza();
            pizza.PizzaId = p.PizzaId;
            pizza.Size = p.Size;
            pizza.Toppings = p.ToppingIDs;
            pizza.UserID = Static.LoggedInUser.UserId;
            return pizza;
        }
        public static Order OrderToModel(Domain.DomainEntities.Order o)
        {
            Order order = new Order();
            order.OrderId = o.OrderId;
            order.OrderTime = o.OrderTime;
            order.LocationID = o.LocationID;
            order.UserID = o.UserID;
            order.PizzaIDs = o.Pizzas;
            return order;
        }
        public static Domain.DomainEntities.Order OrderToDomain(Order o)
        {
            Domain.DomainEntities.Order order = new Domain.DomainEntities.Order();
            order.OrderId = o.OrderId;
            order.OrderTime = o.OrderTime;
            order.LocationID = o.LocationID;
            order.UserID = o.UserID;
            order.Pizzas = o.PizzaIDs;
            return order;
        }
        public static Location LocationToModel(Domain.DomainEntities.Location l)
        {
            Location location = new Location();
            location.LocationId = l.LocationId;
            location.LocationAddress = l.LocationAddress;
            location.LocationCity = l.LocationCity;
            location.LocationState = l.LocationState;
            location.LocationZip = l.LocationZip;
            return location;
            //location.Restaurant = l.RestaurantID;
    }
        public static Domain.DomainEntities.Location LocationToDomain(Location l)
        {
            Domain.DomainEntities.Location location = new Domain.DomainEntities.Location();
            location.LocationId = l.LocationId;
            location.LocationAddress = l.LocationAddress;
            location.LocationCity = l.LocationCity;
            location.LocationState = l.LocationState;
            location.LocationZip = l.LocationZip;
            return location;
        }
        public static User UserToModel(Domain.DomainEntities.User u)
        {
            User user = new User();
            user.UserId = u.UserId;
            user.Username = u.Username;
            user.FirstName = u.FirstName;
            user.LastName = u.LastName;
            user.Pass = u.Pass;
            user.City = u.City;
            user.Email = u.Email;
            user.PizzaIDs = u.Pizzas;
            user.OrderIDs = u.Orders;
            user.LocationIDs = u.LocationIDs;
            return user;
    }
        public static Domain.DomainEntities.User UserToDomain(User u)
        {
            Domain.DomainEntities.User user = new Domain.DomainEntities.User();
            user.UserId = u.UserId;
            user.Username = u.Username;
            user.FirstName = u.FirstName;
            user.LastName = u.LastName;
            user.Pass = u.Pass;
            user.City = u.City;
            user.Email = u.Email;
            user.Pizzas = u.PizzaIDs;
            user.Orders = u.OrderIDs;
            user.LocationIDs = u.LocationIDs;
            return user;
        }
        public static Inventory InventoryToModel(Domain.DomainEntities.Inventory i)
        {
            return null;
        }
        public static Domain.DomainEntities.Inventory InventoryToDomain(Inventory i)
        {
            return null;
        }
        public static Restaurant RestaurantToModel(Domain.DomainEntities.Restaurant r)
        {
            Restaurant restaurant = new Restaurant();
            restaurant.Id = r.Id;
            restaurant.Name = r.Name;
            restaurant.LocationIDs = r.Locations;
            return restaurant;
        }
        public static Domain.DomainEntities.Restaurant RestaurantToDomain(Restaurant r)
        {
            Domain.DomainEntities.Restaurant restaurant = new Domain.DomainEntities.Restaurant();
            restaurant.Id = r.Id;
            restaurant.Name = r.Name;
            restaurant.Locations = r.LocationIDs;
            return restaurant;
        }
    }
}
