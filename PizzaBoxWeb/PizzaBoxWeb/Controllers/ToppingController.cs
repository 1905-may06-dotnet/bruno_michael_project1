using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Domain;
using Domain.Repositories;
using Microsoft.AspNetCore.Http;

namespace PizzaBoxWeb.Controllers
{
    public class ToppingController : Controller
    {
        private readonly IToppingRepository db;
        public ToppingController(IToppingRepository db)
        {
            this.db = db;
        }
        Models.Topping t;
        List<Models.Topping> toppingList = new List<Models.Topping>();

        public ActionResult Index()
        {
            var toppings = db.GetToppings();
            foreach (var topping in toppings)
            {
                t = Models.Converter.ToppingToModel(topping);
                toppingList.Add(t);
            }
            return View(toppingList);
        }
        public ActionResult Details(int id)
        {
            var topping = db.GetTopping(id);
            t = Models.Converter.ToppingToModel(topping);
            return View(t);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection, Models.Topping topping)
        {
            Domain.DomainEntities.Topping dta = Models.Converter.ToppingToDomain(topping);

            try
            {
                db.AddTopping(dta);
                return RedirectToAction("Index");
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
                db.DeleteTopping(db.GetTopping(id));
                return RedirectToAction("Index");
            }
            catch
            {
                return View(t);
            }
        }
        public ActionResult Edit(int id)
        {
            var topping = db.GetTopping(id);
            t = Models.Converter.ToppingToModel(topping);
            return View(t);
        }
        [HttpPost]
        public ActionResult Edit(Models.Topping top)
        {
            //write code to update student 

            return RedirectToAction("Index");
        }
    }
}