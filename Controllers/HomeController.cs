using EatFit.Models;
using EatFit.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EatFit.Controllers
{
    public class HomeController : Controller
    {
        private readonly IFoodItemRepo _foodItems;

        public HomeController(IFoodItemRepo foodItems)
        {
            _foodItems = foodItems;
        }
        public IActionResult Index()
        {
            var homeViewModel = new HomeViewModel {
                FoodMenu = _foodItems.AllFoodItem.Where(c => c.Ratings > 4.5)
            };

            return View(homeViewModel);
        }
    }
}
