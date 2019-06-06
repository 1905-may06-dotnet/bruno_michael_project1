using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Domain;
using Domain.Repositories;

namespace PizzaBoxWeb.Controllers
{
    public class LocationController : Controller
    {
        private readonly ILocationRepository db;
        private readonly IUserRepository usrdb;
        private readonly IRestaurantRepository rstdb;
        public LocationController(ILocationRepository db, IUserRepository usrdb, IRestaurantRepository rstdb)
        {
            this.db = db;
            this.usrdb = usrdb;
            this.rstdb = rstdb;
        }
        Models.Location l;
        List<Models.Location> locList = new List<Models.Location>();

        public ActionResult Index()
        {
            try
            {
                Models.User u = Models.Static.LoggedInUser;
                if (u == null)
                {
                    throw new LoginException("BAD");
                }
                
                foreach (var loc in db.GetLocations(Models.Converter.UserToDomain(u)))
                {
                    l = Models.Converter.LocationToModel(loc);
                    l.Restaurant = rstdb.GetRestaurant(loc.RestaurantID).Name;
                    locList.Add(l);
                }
                return View(locList);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return View();
            }


        }
    }
}