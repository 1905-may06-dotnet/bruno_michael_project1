using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Domain.Repositories;
using Microsoft.AspNetCore.Http;
using Domain;

namespace PizzaBoxWeb.Controllers
{
    
    public class UserController : Controller
    {
        private readonly IUserRepository db;
        private readonly ILocationRepository ldb;
        public UserController(IUserRepository db, ILocationRepository ldb)
        {
            this.db = db;
            this.ldb = ldb;
        }
        Models.User u;
        List<Models.User> userList = new List<Models.User>();

        public ActionResult Index()
        {
            var users = db.GetUsers();
            foreach (var user in users)
            {
                u = new Models.User();
                u.UserId = user.UserId;
                u.Username = user.Username;
                u.FirstName = user.FirstName;
                u.LastName = user.LastName;
                u.City = user.City;
                u.Pass = user.Pass;
                u.Email = user.Email;
                userList.Add(u);
            }
            return View(userList);
        }
        public ActionResult Details(int id)
        {
            var user = db.GetUser(id);
            u = new Models.User();
            u.UserId = user.UserId;
            u.Username = user.Username;
            u.FirstName = user.FirstName;
            u.LastName = user.LastName;
            u.City = user.City;
            u.Pass = user.Pass;
            return View(u);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection, Models.User user)
        {
            Domain.DomainEntities.User dmu = new Domain.DomainEntities.User();
            dmu.Username = user.Username;
            dmu.FirstName = user.FirstName;
            dmu.LastName = user.LastName;
            dmu.City = user.City;
            dmu.Pass = user.Pass;
            dmu.Email = user.Email;
            var locs = ldb.GetLocations(dmu);
            List<int> addIds = new List<int>();
            List<Domain.DomainEntities.Location> addLocs = new List<Domain.DomainEntities.Location>();
            foreach (var loc in locs)
            {
                addIds.Add(loc.LocationId);
                addLocs.Add(loc);
            }
            dmu.LocationIDs = addIds;
            dmu.Locations = addLocs;
            try
            {
                db.AddUser(dmu);
                return RedirectToAction("Index", "Home");
            }
            catch
            {
                return View();
            }
        }
        [HttpGet]
        public ActionResult Delete()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                db.DeleteUser(db.GetUser(id));
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(IFormCollection collection, Models.User user)
        {
            Models.User dmu = new Models.User();
            try
            {
                dmu = Models.Converter.UserToModel(db.GetUser(user.Username));
                if (db.CheckCredentials(user.Username, user.Pass))
                {
                    Models.Static.LoggedInUser = dmu;
                    //session data
                    return RedirectToAction("Index", "Location");//redirect to where you can view stuff.
                }
                else
                {
                    throw new LoginException("Invalid Username/Password combination");
                }
            }
            catch (LoginException e)
            {
                ModelState.AddModelError("Pass", $"{e.Message}");
                return View();
            }
            catch
            {
                ModelState.AddModelError("Username", "Invalid Username");
                return View();
            }

            
        }

    }
}