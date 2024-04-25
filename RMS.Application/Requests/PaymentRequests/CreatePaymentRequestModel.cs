using RMS.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Application.Requests.PaymentRequests;

public class CreatePaymentRequestModel 
{
    public DateTime PaymentDate { get; set; }
    public decimal PaymentAmount { get; set; }
    public PaymentType Type { get; set; }
    public PaymentStatus Status { get; set; }
}

