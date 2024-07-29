using RMS.Domain.Abstract;

namespace RMS.Domain.Entities;

public class Reservation : EntityBase
{
    public DateTime ReservedDate { get; set; }
    public int NumberOfGuests { get; set; }
    public Table? Table { get; set; }

    public int CustomerId { get; set; }
    public int TableId { get; set; }

}
