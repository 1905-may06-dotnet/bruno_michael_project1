using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.DomainEntities
{
    public class Location
    {
        public int LocationId { get; set; }
        public string LocationAddress { get; set; }
        public string LocationCity { get; set; }
        public string LocationState { get; set; }
        public int? LocationZip { get; set; }
        public int RestaurantID { get; set; }
        public List<int> inventories { get; set; }
        public List<int> Users { get; set; }
        public List<int> Orders { get; set; }
        public override string ToString()
        {
            return $"{LocationId}: {LocationAddress}, {LocationCity}, {LocationState} {LocationZip}";
        }
    }
}
