using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Domain;
using Domain.Repositories;

namespace PizzaBoxWeb.Controllers
{
    public class PizzaController : Controller
    {
        private readonly IPizzaRepository db;
        private readonly IToppingRepository tdb;
        public PizzaController(IPizzaRepository db, IToppingRepository tdb)
        {
            this.db = db;
            this.tdb = tdb;
        }
        Models.Pizza p;
        List<Models.Pizza> pizzaList = new List<Models.Pizza>();

        public ActionResult Index()
        {
            var pizzas = db.GetPizzas();
            foreach (var pizza in pizzas)
            {
                p = Models.Converter.PizzaToModel(pizza);
                foreach (var id in p.ToppingIDs)
                {
                    p.Toppings.Add(Models.Converter.ToppingToModel(tdb.GetTopping(id)));
                }
                pizzaList.Add(p);
            }
            return View(pizzaList);
        }
        public ActionResult Details(int id)
        {
            var pizza = db.GetPizza(id);
            p = Models.Converter.PizzaToModel(pizza);
            foreach (var tID in p.ToppingIDs)
            {
                p.Toppings.Add(Models.Converter.ToppingToModel(tdb.GetTopping(tID)));
            }
            return View(p);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection, Models.Pizza pizza)
        {
            Domain.DomainEntities.Pizza dta = Models.Converter.PizzaToDomain(pizza);
            foreach (var tID in p.ToppingIDs)
            {
                p.Toppings.Add(Models.Converter.ToppingToModel(tdb.GetTopping(tID)));
            }
            //dta.Toppings = pizza.Toppings;

            try
            {
                db.AddPizza(dta);
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
                db.DeletePizza(db.GetPizza(id));
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        public ActionResult Edit(int id)
        {
            var pizza = db.GetPizza(id);
            p = new Models.Pizza();
            p.PizzaId = pizza.PizzaId;
            p.Size = pizza.Size;
            //p.Toppings = pizza.Toppings;
            return View(p);
        }
        [HttpPost]
        public ActionResult Edit(Models.Topping top)
        {
            //write code to update student 

            return RedirectToAction("Index");
        }
    }
}