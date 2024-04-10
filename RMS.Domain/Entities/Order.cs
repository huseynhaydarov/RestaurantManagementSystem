using RMS.Domain.Abstract;
using RMS.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Domain.Entities
{
    public class Order : EntityBase
    {
        public DateTime OrderTime { get; set; }
        public string? Location { get; set; }
        public Table? Table { get; set; }
        public decimal TotalPrice { get; set; }
        public List<OrderItem>? itmes { get; set; }
        public OrderType Type { get; set; }
        public Customer? Customer { get; set; }


    }
}
