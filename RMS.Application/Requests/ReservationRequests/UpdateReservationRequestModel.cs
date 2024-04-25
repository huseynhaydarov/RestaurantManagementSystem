using RMS.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace RMS.Application.Requests.ReservationRequests;

public record UpdateReservationRequestModel 
{
    [JsonIgnore]
    public int Id { get; set; } 
    public DateTime ReservedDate { get; set; }
    public int NumberOfGuests { get; set; }
}
