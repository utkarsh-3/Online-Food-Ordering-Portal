using EatFit.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EatFit.Controllers
{
    public class RegisterController : Controller
    {
        private readonly FoodItemDbContext _foodItemDbContext;

        public RegisterController(FoodItemDbContext foodItemDbContext)
        {
            _foodItemDbContext = foodItemDbContext;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Order order)
        {
            if (ModelState.IsValid)
            {
                _foodItemDbContext.Orders.Add(order);

                var rows = from obj in _foodItemDbContext.ShoppingCartItems
                           select obj;
                foreach (var row in rows)
                    _foodItemDbContext.ShoppingCartItems.Remove(row);
                _foodItemDbContext.SaveChanges();
                return RedirectToAction("Checkout");
            }
            return View();
        }

        public ActionResult Checkout()
        {
            ViewBag.CheckoutMsg = "Thanks for you order. You'll soon receive the order ! Sit back and get ready to eat ! ";
            return View();

        }
    }
}
