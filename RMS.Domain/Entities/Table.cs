﻿using RMS.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Domain.Entities
{
    public class Table
    {
        public int Number { get; set; }
        public int Capacity { get; set; }
        public TableStatus Status { get; set; }
        public ICollection<Order>? Orders { get; set; }
    }
}
