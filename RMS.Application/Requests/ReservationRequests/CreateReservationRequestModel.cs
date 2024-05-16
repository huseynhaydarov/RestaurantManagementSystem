using RMS.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Application.Requests.ReservationRequests;

public record CreateReservationRequestModel
{
    public DateTime Date { get; set; }
    public int NumberOfGuests { get; set; }
    public int CustomerId { get; set; }
    public int TableId { get; set; }
}
