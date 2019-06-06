using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Domain;

namespace Data
{
    public static class Mapper
    {
        public static Domain.DomainEntities.Inventory Map(Entities.Inventory i) => new Domain.DomainEntities.Inventory
        {
            Id = i.InventoryId,
            Quantity = i.Quantity,
            LocationID = i.LocationId,
        };
        public static Entities.Inventory Map(Domain.DomainEntities.Inventory i) => new Entities.Inventory
        {
            Quantity = i.Quantity,
            LocationId = i.LocationID
        };
        public static Domain.DomainEntities.Location Map(Entities.StoreLocation l) => new Domain.DomainEntities.Location
        {
            LocationId = l.LocationId,
            LocationAddress = l.LocationAddress,
            LocationCity = l.LocationCity,
            LocationState = l.LocationState,
            LocationZip = l.LocationZip,
            RestaurantID = l.RestaurantId
            
        };
        public static Entities.StoreLocation Map(Domain.DomainEntities.Location l) => new Entities.StoreLocation
        {
            LocationId = l.LocationId,
            LocationAddress = l.LocationAddress,
            LocationCity = l.LocationCity,
            LocationState = l.LocationState,
            LocationZip = l.LocationZip,
            RestaurantId = l.RestaurantID
    };
        public static Domain.DomainEntities.Order Map(Entities.Requisition o) => new Domain.DomainEntities.Order
        {
            OrderId = o.OrderId,
            OrderTime = o.OrderTime,
        };
        public static Entities.Requisition Map(Domain.DomainEntities.Order o) => new Entities.Requisition
        {
            OrderId = o.OrderId,
            OrderTime = o.OrderTime,
        };
        public static Domain.DomainEntities.Pizza Map(Entities.Pizza p) => new Domain.DomainEntities.Pizza
        {
            PizzaId = p.PizzaId,
            Size = p.Size,
        };
        public static Entities.Pizza Map(Domain.DomainEntities.Pizza p) => new Entities.Pizza
        {
            PizzaId = p.PizzaId,
            Size = p.Size,
        };
        public static Domain.DomainEntities.Restaurant Map(Entities.Restaurant r) => new Domain.DomainEntities.Restaurant
        {
            Id = r.RestaurantId,
            Name = r.RestaurantName,
        };
        public static Entities.Restaurant Map(Domain.DomainEntities.Restaurant r) => new Entities.Restaurant
        {
            RestaurantName = r.Name,
        };
        public static Domain.DomainEntities.Topping Map(Entities.Topping t) => new Domain.DomainEntities.Topping
        {
            ToppingId = t.ToppingId,
            ToppingName = t.ToppingName,
            Price = t.Price
        };
        public static Entities.Topping Map(Domain.DomainEntities.Topping t) => new Entities.Topping
        {
            ToppingName = t.ToppingName,
            Price = t.Price
        };
        public static Domain.DomainEntities.User Map(Entities.Person u) => new Domain.DomainEntities.User
        {
            UserId = u.PersonId,
            Username = u.Username,
            FirstName = u.FirstName,
            LastName = u.LastName,
            Pass = u.Pass,
            City = u.City,
            Email = u.Email
        };
        public static Entities.Person Map(Domain.DomainEntities.User u) => new Entities.Person
        {
            Username = u.Username,
            FirstName = u.FirstName,
            LastName = u.LastName,
            Pass = u.Pass,
            City = u.City,
            Email = u.Email
        };
        public static IEnumerable<Domain.DomainEntities.Inventory> Map(IEnumerable<Entities.Inventory> i) => i.Select(Map);
        public static IEnumerable<Entities.Inventory> Map(IEnumerable<Domain.DomainEntities.Inventory> i) => i.Select(Map);
        public static IEnumerable<Domain.DomainEntities.Location> Map(IEnumerable<Entities.StoreLocation> l) => l.Select(Map);
        public static IEnumerable<Entities.StoreLocation> Map(IEnumerable<Domain.DomainEntities.Location> l) => l.Select(Map);
        public static IEnumerable<Domain.DomainEntities.Order> Map(IEnumerable<Entities.Requisition> l) => l.Select(Map);
        public static IEnumerable<Entities.Requisition> Map(IEnumerable<Domain.DomainEntities.Order> l) => l.Select(Map);
        public static IEnumerable<Domain.DomainEntities.Pizza> Map(IEnumerable<Entities.Pizza> p) => p.Select(Map);
        public static IEnumerable<Entities.Pizza> Map(IEnumerable<Domain.DomainEntities.Pizza> l) => l.Select(Map);
        public static IEnumerable<Domain.DomainEntities.Restaurant> Map(IEnumerable<Entities.Restaurant> r) => r.Select(Map);
        public static IEnumerable<Entities.Restaurant> Map(IEnumerable<Domain.DomainEntities.Restaurant> r) => r.Select(Map);
        public static IEnumerable<Domain.DomainEntities.Topping> Map(IEnumerable<Entities.Topping> r) => r.Select(Map);
        public static IEnumerable<Entities.Topping> Map(IEnumerable<Domain.DomainEntities.Topping> r) => r.Select(Map);
        public static IEnumerable<Domain.DomainEntities.User> Map(IEnumerable<Entities.Person> r) => r.Select(Map);
        public static IEnumerable<Entities.Person> Map(IEnumerable<Domain.DomainEntities.User> r) => r.Select(Map);
    }
}
