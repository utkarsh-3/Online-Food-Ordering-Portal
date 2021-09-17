using EatFit.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EatFit.Models
{
    public class ShoppingCart
    {
        private readonly FoodItemDbContext _foodItemDbContext;

        public string ShoppingCartId { get; set; }

        public List<ShoppingCartItems> ShoppingCartItems { get; set; }

        public ShoppingCart(FoodItemDbContext FoodItemDbContext)
        {
            _foodItemDbContext = FoodItemDbContext;
        }
        public static ShoppingCart GetCart(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;
            var context = services.GetService<FoodItemDbContext>();

            string cartId = session.GetString("CartId") ?? Guid.NewGuid().ToString();
            session.SetString("CartId", cartId);
            return new ShoppingCart(context) { ShoppingCartId = cartId };

        }

        public void AddToCart(FoodItem foodItem, int amount)
        {
            var shoppingCartItem =
                _foodItemDbContext.ShoppingCartItems.SingleOrDefault(
                    s => s.foodItem.Id == foodItem.Id && s.ShoppingCartId == ShoppingCartId);
            if (shoppingCartItem == null)
            {
                shoppingCartItem = new ShoppingCartItems
                {
                    ShoppingCartId = ShoppingCartId,
                    foodItem = foodItem,
                    Amount = 1
                };
                _foodItemDbContext.ShoppingCartItems.Add(shoppingCartItem);
            }
            else
            {
                shoppingCartItem.Amount++;
            }
            _foodItemDbContext.SaveChanges();
        }


        public int RemoveFromCart(FoodItem foodItem)
        {

            var shoppingCartItem =
                _foodItemDbContext.ShoppingCartItems.SingleOrDefault(
                    s => s.foodItem.Id == foodItem.Id && s.ShoppingCartId == ShoppingCartId);
            var localamount = 0;

            if (shoppingCartItem != null)
            {
                if (shoppingCartItem.Amount > 1)
                {
                    shoppingCartItem.Amount--;
                    localamount = shoppingCartItem.Amount;
                }
                else
                {
                    _foodItemDbContext.ShoppingCartItems.Remove(shoppingCartItem);
                }
            }
            _foodItemDbContext.SaveChanges();

            return localamount;
        }

        public List<ShoppingCartItems> GetShoppingCartItems()
        {
            return ShoppingCartItems ?? (
                ShoppingCartItems =
                _foodItemDbContext.ShoppingCartItems.Where(c => c.ShoppingCartId == ShoppingCartId) 
               .Include(s => s.foodItem).ToList());


        }

        public void ClearCart()
        {
            var shoppingCartItemsList = ShoppingCartItems ?? (
                ShoppingCartItems = _foodItemDbContext.ShoppingCartItems.Where(c => c.ShoppingCartId == ShoppingCartId).Include(s => s.foodItem).ToList());
            
            if (shoppingCartItemsList == null)
                return;
            
            foreach (var item in shoppingCartItemsList)
            {
                _foodItemDbContext.ShoppingCartItems.Remove(item);
            }
            _foodItemDbContext.SaveChanges();
        }
      
       
        public decimal GetShoppingCartTotal()
        {
             var ShoppingCartItems =
                _foodItemDbContext.ShoppingCartItems.Where(c => c.ShoppingCartId == ShoppingCartId)
               .Include(s => s.foodItem).ToList();

            decimal total = 0;
            if (ShoppingCartItems == null)
                return 0;
            foreach (var item in ShoppingCartItems)
            {
                total += (item.Amount * item.foodItem.Cost);
            }
            return total;

        }

    }
}
