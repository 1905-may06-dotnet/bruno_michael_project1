using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.DomainEntities
{
    public class User
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Pass { get; set; }
        public string City { get; set; }
        public string Email { get; set; }
        public List<int> Pizzas { get; set; }
        public List<int> Orders { get; set; }
        public List<int> LocationIDs { get; set; }
        public List<Location> Locations { get; set; }
        public override string ToString()
        {
            return $"User: {UserId}\nUsername: {Username}\nName: {FirstName} {LastName}";
        }
    }
}
