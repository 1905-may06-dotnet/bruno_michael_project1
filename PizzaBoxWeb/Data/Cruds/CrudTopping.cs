using System.Collections.Generic;
using System.Linq;
using Domain.DomainEntities;
using Domain.Repositories;

namespace Data.Cruds
{
    public class CrudTopping : IToppingRepository
    {
        private readonly Entities.PizzaBoxContext _db;
        public CrudTopping(Entities.PizzaBoxContext db)
        {
            _db = db;
        }
        public IEnumerable<Topping> GetToppings()
        {
            var toppings = _db.Topping;
            return Mapper.Map(toppings);
        }
        public IEnumerable<Topping> GetToppings(Pizza p)
        {
            var pizzaIds = _db.PizzaTopping.Where(x => x.PizzaId == p.PizzaId);
            List<Topping> toppings = new List<Topping>();
            foreach (var id in pizzaIds)
            {
                var topping = _db.Topping.Where(x => x.ToppingId == id.ToppingId).FirstOrDefault();
                toppings.Add(Mapper.Map(topping));
            }
            return toppings;
        }
        public IEnumerable<Topping> GetToppings(Inventory i)
        {
            var inventoryIds = _db.InventoryToppings.Where(x => x.InventoryId == i.Id);
            List<Topping> toppings = new List<Topping>();
            foreach (var id in inventoryIds)
            {
                var topping = _db.Topping.Where(x => x.ToppingId == id.ToppingId).FirstOrDefault();
                toppings.Add(Mapper.Map(topping));
            }
            return toppings;
        }
        public Topping GetTopping(int id)
        {
            var topping = _db.Topping.Where(r => r.ToppingId == id).FirstOrDefault();
            return Mapper.Map(topping);
        }
        public Topping GetTopping(string name)
        {
            var topping = _db.Topping.Where(x => x.ToppingName == name).FirstOrDefault();
            return Mapper.Map(topping);
        }
        public void AddTopping(Topping t)
        {
            _db.Topping.Add(Mapper.Map(t));
            _db.SaveChanges();
        }
        public void DeleteTopping(Topping t)
        {
            _db.Topping.Remove(_db.Topping.Find(t.ToppingId));
        }
    }
}
