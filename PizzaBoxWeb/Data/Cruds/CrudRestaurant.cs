using System.Collections.Generic;
using System.Linq;
using Domain.DomainEntities;
using Domain.Repositories;

namespace Data.Cruds
{
    public class CrudRestaurant : IRestaurantRepository
    {
        private readonly Entities.PizzaBoxContext _db;
        public CrudRestaurant(Entities.PizzaBoxContext db)
        {
            _db = db;
        }
        public IEnumerable<Restaurant> GetRestaurants()
        {
            var restaurants = _db.Restaurant;
            return Mapper.Map(restaurants);
        }
        public Restaurant GetRestaurant(int id)
        {
            var restaurant = _db.Restaurant.Where(r => r.RestaurantId == id).FirstOrDefault();
            return Mapper.Map(restaurant);
        }
        public void AddRestaurant(Restaurant x)
        {
            _db.Restaurant.Add(Mapper.Map(x));
            _db.SaveChanges();
        }
        public void DeleteRestaurant(Restaurant x)
        {
            _db.Restaurant.Remove(_db.Restaurant.Find(x.Id));
        }
    }
}