using RMS.Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Domain.Entities
{
    public class Payment : EntityBase
    {
        public Order? Order { get; set; }

        public DateTime PaymentDate { get; set; }

        public decimal PaymentAmount { get; set; }
    }
}
