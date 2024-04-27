﻿using RMS.Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Domain.Entities;

public class Reservation : EntityBase
{
    public DateTime ReservedDate { get; set; }
    public int NumberOfGuests { get; set; }
    public Customer? Customer { get; set; }
    public int CustomerId { get; set; }
    public ReservationTable? ReservationTable { get; set; }
    public int ReservationTableId { get; set; }    

}
