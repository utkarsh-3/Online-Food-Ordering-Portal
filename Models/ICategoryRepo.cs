using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EatFit.Models
{
   public interface ICategoryRepo
    {
        IEnumerable<Category> AllCategories { get; }
    }
}
