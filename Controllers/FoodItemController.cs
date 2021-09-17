using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EatFit.Models;
using EatFit.ViewModels;

namespace EatFit.Controllers
{
    public class FoodItemController : Controller
    {
        private readonly IFoodItemRepo _FoodItemRepo;
        private readonly ICategoryRepo _categoryRepo;


        public FoodItemController(IFoodItemRepo foodItems,ICategoryRepo category)
        {
            _FoodItemRepo = foodItems;
            _categoryRepo = category;
        }

        public IActionResult Index(string category)
        {
            IEnumerable<FoodItem> FoodItems;
            string currentCategory;

            if (string.IsNullOrEmpty(category))
            {
                FoodItems = _FoodItemRepo.AllFoodItem.OrderBy(p => p.Ratings);
                currentCategory = "All Items";
            }
            else
            {
                FoodItems = _FoodItemRepo.AllFoodItem.Where(p => p.CategoryName == category).OrderBy(p => p.Id);
                currentCategory = _categoryRepo.AllCategories.FirstOrDefault(c => c.CategoryName == category)?.CategoryName;
            }
            return View(new FoodItemViewModel
            {
                FoodMenu = FoodItems,
                CurrentCategory=currentCategory
            });
        }

        public IActionResult Search(string searchString)
        {
            IEnumerable<FoodItem> FoodItems;
            string currentCategory;

            if (string.IsNullOrEmpty(searchString))
            {
                FoodItems = _FoodItemRepo.AllFoodItem.OrderBy(p => p.Ratings);
                currentCategory = "All Items";
            }
            else
            {
                FoodItems = _FoodItemRepo.AllFoodItem.Where(p => p.Name.ToLower().Contains(searchString.ToLower()));
                currentCategory = "All Items";
            }
            return View(new FoodItemViewModel
            {
                FoodMenu = FoodItems,
                CurrentCategory = currentCategory
            });
        }

        public IActionResult Filter(Boolean foodChoice,string foodType)
        {
            IEnumerable<FoodItem> FoodItems;
            string currentCategory;

            if (foodType == "Drink" || foodType == "Snacks" || foodType == "Dessert")
                FoodItems = _FoodItemRepo.AllFoodItem.Where(p => p.IsVeg == foodChoice && p.FoodType.ToLower().StartsWith(foodType.ToLower()));
            else
                FoodItems = _FoodItemRepo.AllFoodItem.Where(p => p.IsVeg == foodChoice);
            currentCategory = "All Items";
            
            return View(new FoodItemViewModel
            {
                FoodMenu = FoodItems,
                CurrentCategory = currentCategory
            });
        }
        public IActionResult Details(int id)
        {
            var tmp = _FoodItemRepo.GetFoodItemById(id);
            if (tmp == null)
                return NotFound();
            return View(tmp);
        }

    }
}
