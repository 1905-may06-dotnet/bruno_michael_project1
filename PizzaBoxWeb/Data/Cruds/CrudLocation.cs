using System.Collections.Generic;
using System.Linq;
using Domain.DomainEntities;
using Domain.Repositories;

namespace Data.Cruds
{
    public class CrudLocation : ILocationRepository
    {
        private readonly Entities.PizzaBoxContext _db;
        public CrudLocation(Entities.PizzaBoxContext db)
        {
            _db = db;
        }
        public IEnumerable<Location> GetLocations()
        {
            return Mapper.Map(_db.StoreLocation).ToList();
        }
        public IEnumerable<Location> GetLocations(User p)
        {
            List<Location> locations = Mapper.Map(_db.StoreLocation).ToList();
            List<Location> add = new List<Location>();
            foreach (var loc in locations)
            {
                if (loc.LocationCity == p.City)
                {
                    add.Add(loc);
                }
            }
            return add;
        }
        public Location GetLocation(string address)
        {
            var location = _db.StoreLocation.Where(x => x.LocationAddress == address).FirstOrDefault();
            return Mapper.Map(location);
        }
        public Location GetLocation(int id)
        {
            var location = _db.StoreLocation.Where(r => r.LocationId == id).FirstOrDefault();
            return Mapper.Map(location);
        }
        public void AddLocation(Location t)
        {
            DbInstance.Instance.StoreLocation.Add(Mapper.Map(t));
            _db.SaveChanges();
        }
        public void DeleteLocation(Location t)
        {
            _db.StoreLocation.Remove(_db.StoreLocation.Find(t.LocationId));
        }
    }
}
