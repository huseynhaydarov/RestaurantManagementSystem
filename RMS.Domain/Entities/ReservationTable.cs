using RMS.Domain.Abstract;

namespace RMS.Domain.Entities
{
    public class ReservationTable : EntityBase
    {
        public Reservation? Reservation { get; set; }
        public int ReservationId { get; set; }
        public Table? Table { get; set; }
        public int Tableid { get; set; }
    }
}