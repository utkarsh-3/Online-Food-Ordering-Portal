using EatFit.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EatFit.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<FoodItem> FoodMenu { get; set; }

        public string searchString { get; set; }
    }
}
