using System.Collections.Generic;
using System.Linq;
using Domain.Repositories;
using Domain.DomainEntities;

namespace Data.Cruds
{
    public class CrudInventory : IInventoryRepository
    {
        private readonly Entities.PizzaBoxContext _db;
        public CrudInventory(Entities.PizzaBoxContext db)
        {
            _db = db;
        }
        public IEnumerable<Inventory> GetInventorys()
        {
            return Mapper.Map(_db.Inventory).ToList();
        }
        public Inventory GetInventory(int id)
        {
            var inventory = _db.Inventory.Where(x => x.InventoryId == id).FirstOrDefault();
            if (inventory != null)
            {
                return Mapper.Map(inventory);
            }
            return null;
        }
        public void AddInventory(Inventory x)
        {
            _db.Inventory.Add(Mapper.Map(x));
            _db.SaveChanges();
        }
        public void DeleteInventory(Inventory x)
        {
            _db.Inventory.Remove(_db.Inventory.Find(x.Id));
        }
    }
}




