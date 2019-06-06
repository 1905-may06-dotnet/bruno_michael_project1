using System.Collections.Generic;

namespace Domain.DomainEntities
{
    public class Restaurant
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<int> Locations { get; set; }
    }
}
