using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EatFit.Models
{
    public class FoodItemRepo : IFoodItemRepo
    {
        private readonly FoodItemDbContext _foodItemDbContext;

        public FoodItemRepo(FoodItemDbContext foodItemDb)
        {
            _foodItemDbContext = foodItemDb;
        }
        public IEnumerable<FoodItem> AllFoodItem => _foodItemDbContext.FoodItems;

        public FoodItem GetFoodItemById(int id)
        {
            return _foodItemDbContext.FoodItems.FirstOrDefault<FoodItem>(p => p.Id == id);
        }
    }
}
