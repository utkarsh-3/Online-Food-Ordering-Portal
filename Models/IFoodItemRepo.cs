using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EatFit.Models
{
    public interface IFoodItemRepo
    {
        IEnumerable<FoodItem> AllFoodItem { get; }

        FoodItem GetFoodItemById(int FoodItemId);
    }
}
