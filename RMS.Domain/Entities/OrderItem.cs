using RMS.Domain.Abstract;
using RMS.Domain.Enum;

namespace RMS.Domain.Entities;

public class OrderItem : EntityBase
{
    public double Count { get; set; }
    public OrderStatus Status { get; set; }
    public MenuItem? MenuItem { get; set; }
    public int MenuItemId { get; set; }
}