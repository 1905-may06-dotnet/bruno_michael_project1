using System.Collections.Generic;
using System.Linq;
using Domain.DomainEntities;
using Domain.Repositories;

namespace Data.Cruds
{
    public class CrudPizza : IPizzaRepository
    {
        private readonly Entities.PizzaBoxContext _db;
        public CrudPizza(Entities.PizzaBoxContext db)
        {
            _db = db;
        }
        public IEnumerable<Pizza> GetPizzas()
        {
            var pizzas = _db.Pizza;
            return Mapper.Map(pizzas);
        }
        public IEnumerable<Pizza> GetPizzas(Order o)
        {
            var pizzas = _db.Pizza.Where(x => x.OrderId == o.OrderId);
            return Mapper.Map(pizzas);
        }
        public Pizza GetPizza(int id)
        {
            var pizza = _db.Pizza.Where(r => r.PizzaId == id).FirstOrDefault();
            return Mapper.Map(pizza);
        }
        public void AddPizza(Pizza x)
        {
            _db.Pizza.Add(Mapper.Map(x));
            _db.SaveChanges();
        }
        public void DeletePizza(Pizza p)
        {
            _db.Pizza.Remove(_db.Pizza.Find(p.PizzaId));
        }
        public void LinkToppingToPizza(Topping t, Pizza p)
        {
            Entities.PizzaTopping pt = new Entities.PizzaTopping() { PizzaId = p.PizzaId, ToppingId = t.ToppingId };
            _db.PizzaTopping.Add(pt);
            _db.SaveChanges();
        }
    }
}