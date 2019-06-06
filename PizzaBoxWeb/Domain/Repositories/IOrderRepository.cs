using System;
using System.Collections.Generic;
using System.Text;
using Domain.DomainEntities;


namespace Domain.Repositories
{
    public interface IOrderRepository
    {
        IEnumerable<Order> GetOrders();
        IEnumerable<Order> GetOrders(int personID);
        Order GetOrder(int id);
        void AddOrder(Order o);
        void DeleteOrder(Order o);
    }
}

