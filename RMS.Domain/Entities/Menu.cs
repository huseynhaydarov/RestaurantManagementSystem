using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Domain.Entities
{
    public class Menu
    {
        public decimal Price { get; set; }
        public FoodItem? FoodItem { get; set; }
    }
}
