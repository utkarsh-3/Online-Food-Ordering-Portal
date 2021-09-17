using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EatFit.Models
{
    public class InMemoryCategoryRepo : ICategoryRepo
    {
        public IEnumerable<Category> AllCategories => new List<Category>
        {
            new Category{CategoryId=1,CategoryName="Breakfast",Description="The most important meal of the day !"},
            new Category{CategoryId=2,CategoryName="Lunch",Description="The most heaviest meal of the day !"},
            new Category{CategoryId=3,CategoryName="Dinner",Description="The most light meal of the day !"},

        };
    }
}
