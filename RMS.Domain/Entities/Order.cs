using RMS.Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Domain.Entities
{
    public class Order : EntityBase
    {
        public DateTime OrderDate { get; set; }

        public string? OrderLocation { get; set; }

        public Customer? Customer { get; set; }
        
    }
}
