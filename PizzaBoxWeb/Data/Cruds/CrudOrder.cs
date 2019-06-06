using System.Collections.Generic;
using System.Linq;
using Domain.DomainEntities;
using Domain.Repositories;

namespace Data.Cruds
{
    public class CrudOrder : IOrderRepository
    {
        private readonly Entities.PizzaBoxContext _db;
        public CrudOrder(Entities.PizzaBoxContext db)
        {
            _db = db;
        }
        public IEnumerable<Order> GetOrders()
        {
            var orders = _db.Requisition;
            return Mapper.Map(orders);
        }
        public IEnumerable<Order> GetOrders(int personID)
        {
            var orders = _db.Requisition.Where(x => x.UserId == personID);
            return Mapper.Map(orders);
        }
        public Order GetOrder(int id)
        {
            var order = _db.Requisition.Where(z => z.UserId == id).FirstOrDefault();
            return Mapper.Map(order);
        }
        public void AddOrder(Order x)
        {
            _db.Requisition.Add(Mapper.Map(x));
            _db.SaveChanges();
        }
        public void DeleteOrder(Order x)
        {
            _db.Requisition.Remove(_db.Requisition.Find(x.OrderId));
        }
    }
}