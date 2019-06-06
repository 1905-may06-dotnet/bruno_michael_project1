using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PizzaBoxWeb.Models;

namespace PizzaBoxWeb.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            Static.LoggedInUser = null;
            Static.currentLocation = null;
            Static.currentOrder = null;
            Static.currentPizza = null;
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
