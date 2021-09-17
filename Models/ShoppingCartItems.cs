using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EatFit.Models
{
    public class ShoppingCartItems
    {
        [Key]
        public int ShoppingCartItemid { get; set; }
        public FoodItem foodItem { get; set; }
        public int Amount { get; set; }
        
        public string ShoppingCartId { get; set; }
       

    }
}
