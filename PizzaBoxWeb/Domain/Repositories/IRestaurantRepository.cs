using System;
using System.Collections.Generic;
using System.Text;
using Domain.DomainEntities;


namespace Domain.Repositories
{
    public interface IRestaurantRepository
    {
        IEnumerable<Restaurant> GetRestaurants();
        Restaurant GetRestaurant(int id);
        void AddRestaurant(Restaurant x);
        void DeleteRestaurant(Restaurant x);
    }
}
