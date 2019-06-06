using System;
using System.Collections.Generic;
using System.Text;
using Domain.DomainEntities;


namespace Domain.Repositories
{
    public interface IUserRepository
    {
        IEnumerable<User> GetUsers();
        IEnumerable<User> GetUsers(Location l);
        User GetUser(int id);
        User GetUser(string username);
        void AddUser(User u);
        void DeleteUser(User u);
        bool CheckCredentials(string username, string password);
    }
}
