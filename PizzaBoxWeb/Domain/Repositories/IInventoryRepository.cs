using System.Collections.Generic;
using Domain.DomainEntities;

namespace Domain.Repositories
{
    public interface IInventoryRepository
    {
        IEnumerable<Inventory> GetInventorys();
        Inventory GetInventory(int id);
        void AddInventory(Inventory x);
        void DeleteInventory(Inventory x);
    }
}
