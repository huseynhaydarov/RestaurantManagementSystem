using RMS.Domain.Abstract;

namespace RMS.Domain.Entities;

public class Customer : EntityBase
{
    public string? FullName { get; set; }
    public string? Email { get; set; }
    public string? Address { get; set; }
    public string? PhoneNumber { get; set; }
    public ICollection<Order>? Orders { get; set; }
    public ICollection<Reservation>? Reservations { get; set; }
}