using EatFit.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EatFit.ViewModels
{
    public class FoodItemViewModel
    {
        public IEnumerable<FoodItem> FoodMenu { get; set; }

        public string CurrentCategory { get; set; }
    }
    public enum FoodType
    {
        Dessert,
        Drink,
        Snacks,
        All,
    }
    public enum Price
    {
        Lakh=100000,
        Thousand=1000,
        Hundred=100
    }
    public enum Rating
    {
        Five = 5,
        Four = 4,
        Three = 3,
        Two=2,
        One=1,
        Zero=0
    }
}
