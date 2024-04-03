using RMS.Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Domain.Entities
{
    public class Reservation : EntityBase
    {
        public Customer? Customer { get; set; }
        public DateTime Date { get; set; }
        public int NumofGuests { get; set; }
    }
}
