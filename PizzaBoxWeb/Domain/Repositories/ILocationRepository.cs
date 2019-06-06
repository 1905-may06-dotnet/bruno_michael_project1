using System;
using System.Collections.Generic;
using System.Text;
using Domain.DomainEntities;


namespace Domain.Repositories
{
    public interface ILocationRepository
    {
        IEnumerable<Location> GetLocations();
        IEnumerable<Location> GetLocations(User p);
        Location GetLocation(string address);
        Location GetLocation(int id);
        void AddLocation(Location t);
        void DeleteLocation(Location t);
    }
}
