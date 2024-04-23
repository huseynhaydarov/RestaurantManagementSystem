using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Application.Requests.OrderRequests;

public record UpdateOrderRequestModel
{
    public int Id { get; set; }
    public DateTime DateTime { get; set; }
    public string? Location { get; set; }
    public decimal TotalPrice { get; set; }
    public int CustomerId { get; set; }
   
}
