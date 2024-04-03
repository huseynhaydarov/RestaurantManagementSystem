using RMS.Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Domain.Entities
{
    public class Food : EntityBase
    {
        public string? Name { get; set; }

        public string? Description { get; set; }

        public decimal UnitPrice { get; set; }

        public enum FoodCategory;
    }
}
