using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EatFit.Models
{
    public class InMemoryFoodItem:IFoodItemRepo
    {
        List<FoodItem> _foodItems;

        public InMemoryFoodItem()
        {
            _foodItems = new List<FoodItem>
            {
                new FoodItem{Id=1,Name="Pasta",Cost=140,IsVeg=true,ShortDescription="Crispy and Spicy",LongDescription="Prepared with this and that",CategoryName="Dinner",
                Ratings=3.4,ImageUrl="/img/pasta.jpg"},
                
                new FoodItem{Id=2,Name="Poha",Cost=40,IsVeg=true,ShortDescription="Yummy ",LongDescription="Prepared with this and that",CategoryName="Breakfast",
                Ratings=4.4,ImageUrl="/img/poha.jpg"},
                
                new FoodItem{Id=3,Name="Pizza",Cost=100,IsVeg=true,ShortDescription="Spicy",LongDescription="Prepared with this and that",CategoryName="Dinner",
                Ratings=4,ImageUrl="/img/pizza.jpg"},
                
                new FoodItem{Id=4,Name="Burger",Cost=340,IsVeg=false,ShortDescription=" Spicy",LongDescription="Prepared with this and that",CategoryName="Lunch",
                Ratings=5,ImageUrl="/img/burger.jpg"},

            };
        }

        public IEnumerable<FoodItem> AllFoodItem
        {
            get
            {
                return _foodItems;
            }
        }

        public FoodItem GetFoodItemById(int FoodItemId)
        {
            throw new NotImplementedException();
        }
    }
}
