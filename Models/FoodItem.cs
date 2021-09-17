using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EatFit.Models
{
    public class FoodItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public Boolean IsVeg { get; set; }

        public string FoodType { get; set; }

        public int Cost { get; set; }
        public double Ratings { get; set; }
        public string ImageUrl { get; set; }
        public string CategoryName { get; set; }
        public Category Category { get; set; }
    }


}
