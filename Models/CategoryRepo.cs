using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EatFit.Models
{
    public class CategoryRepo : ICategoryRepo
    {

        private readonly FoodItemDbContext _foodItemDbContext;

        public CategoryRepo(FoodItemDbContext foodItemDb)
        {
            _foodItemDbContext = foodItemDb;
        }
        public IEnumerable<Category> AllCategories => _foodItemDbContext.Categories;
    }
}
