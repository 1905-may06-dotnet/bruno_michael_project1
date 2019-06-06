using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.DomainEntities
{
    public class Topping
    {
        public int ToppingId { get; set; }
        public string ToppingName { get; set; }
        public double? Price { get; set; }
        public override string ToString()
        {
            return $"{ToppingName}";
        }
    }
}
