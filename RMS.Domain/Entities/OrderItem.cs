using RMS.Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Domain.Entities
{
    public class OrderItem : EntityBase
    {
        public Food? Food { get; set; }

        public int Quantity { get; set; }

        public decimal UnitPrice { get; set; }
    }
}
