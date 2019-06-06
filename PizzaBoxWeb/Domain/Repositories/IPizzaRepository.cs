using System;
using System.Collections.Generic;
using System.Text;
using Domain.DomainEntities;


namespace Domain.Repositories
{
    public interface IPizzaRepository
    {
        IEnumerable<Pizza> GetPizzas();
        IEnumerable<Pizza> GetPizzas(Order o);
        Pizza GetPizza(int id);
        void AddPizza(Pizza x);
        void DeletePizza(Pizza x);
        void LinkToppingToPizza(Topping t, Pizza p);
    }
}
