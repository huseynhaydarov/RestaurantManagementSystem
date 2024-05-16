using RMS.Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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