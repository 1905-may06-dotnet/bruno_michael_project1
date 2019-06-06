using System.Collections.Generic;
using System.Linq;
using Domain.DomainEntities;
using Domain.Repositories;

namespace Data.Cruds
{
    public class CrudUser : IUserRepository
    {
        private readonly Entities.PizzaBoxContext _db;
        public CrudUser(Entities.PizzaBoxContext db)
        {
            _db = db;
        }
        public IEnumerable<User> GetUsers()
        {
            return _db.Person.Select(x => Mapper.Map(x));
            //var persons = _db.Person;
            //return Mapper.Map(persons);
        }
        public IEnumerable<User> GetUsers(Location l)
        {
            var personId = _db.UserLocation.Where(x => x.LocationId == l.LocationId);
            List<User> persons = new List<User>();
            foreach (var id in personId)
            {
                var person = _db.Person.Where(x => x.PersonId == id.UserId).FirstOrDefault();
                persons.Add(Mapper.Map(person));
            }
            return persons;
        }
        public User GetUser(int id)
        {
            var person = _db.Person.Where(r => r.PersonId == id).FirstOrDefault();
            return Mapper.Map(person);
        }
        public User GetUser(string username)
        {
            var person = _db.Person.Where(z => z.Username == username).FirstOrDefault();
            return Mapper.Map(person);
        }
        public void AddUser(User x)
        {
            _db.Person.Add(Mapper.Map(x));
            _db.SaveChanges();
        }
        public void DeleteUser(User u)
        {
            _db.Person.Remove(_db.Person.Find(u.UserId));
            _db.SaveChanges();
        }
        
        public bool CheckCredentials(string username, string password)
        {
            var person = _db.Person.Where(r => r.Username == username).FirstOrDefault();
            if (person == null)
            {
                return false;
            }
            if(person.Pass != password)
            {
                return false;
            }
            return true;
        }
    }
}
