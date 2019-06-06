using System;
using System.Collections.Generic;
using System.Text;
using Domain.DomainEntities;


namespace Domain.Repositories
{
    public interface IToppingRepository
    {
        IEnumerable<Topping> GetToppings();
        IEnumerable<Topping> GetToppings(Pizza p);
        IEnumerable<Topping> GetToppings(Inventory i);
        Topping GetTopping(int id);
        Topping GetTopping(string name);
        void AddTopping(Topping t);
        void DeleteTopping(Topping t);
    }
}