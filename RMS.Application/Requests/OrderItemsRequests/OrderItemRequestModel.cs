using RMS.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Application.Requests.OrderItemsRequests
{
    public class OrderItemRequestModel : BaseRequest
    {
        public int Id { get; set; }
        public int MenuId { get; set; }
        public double Count { get; set; }   
        public OrderStatus Status { get; set; }
    }
}
