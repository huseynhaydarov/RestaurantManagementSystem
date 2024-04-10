using RMS.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Domain.Entities
{
    public class MenuItem
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public decimal Price { get; set; }
        public FoodCategory Category { get; set; }
       
    }
}
