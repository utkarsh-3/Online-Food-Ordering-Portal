using EatFit.Models;
using EatFit.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EatFit.Controllers
{
    [Authorize]
    public class ShoppingCartController : Controller
    {
        private readonly IFoodItemRepo _foodItemRepo;
        private readonly ShoppingCart _shoppingCart;

        public ShoppingCartController(IFoodItemRepo foodItemRepo, ShoppingCart shoppingCart)
        {
            _foodItemRepo = foodItemRepo;
            _shoppingCart = shoppingCart;
        }
        public IActionResult Index()
        {
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;

            var shoppingCartViewModel = new ShoppingCartViewModel()
            {
                ShoppingCart = _shoppingCart,
                ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal()

            };

            return View(shoppingCartViewModel);

        }

        public RedirectToActionResult AddToShoppingCart(int foodItemId)
        {
            var selectedFoodItem = _foodItemRepo.AllFoodItem.FirstOrDefault(p => p.Id == foodItemId);
            if (selectedFoodItem != null)
            {
                _shoppingCart.AddToCart(selectedFoodItem, 1);
            }
            return RedirectToAction("Index");
        }

        public RedirectToActionResult RemoveFromShoppingCart(int foodItemId)
        {
            var selectedFoodItem = _foodItemRepo.AllFoodItem.FirstOrDefault(p => p.Id == foodItemId);
            if (selectedFoodItem != null)
            {
                _shoppingCart.RemoveFromCart(selectedFoodItem);
            }
            return RedirectToAction("Index");
        }
        public IActionResult ClearCart()
        {
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ClearCart();
            
            return RedirectToAction("Index");
        }
    }
    
}
