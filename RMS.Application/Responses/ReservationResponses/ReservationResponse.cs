using RMS.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Application.Responses.ReservationResponses;

public record ReservationResponse
{
    public int Id { get; set; }
    public DateTime Date { get; set; }
    public int NumberOfGuests { get; set; }
    public int CustomerId { get; set; }
    public int ReservationTableId { get; set; }

}
