using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class TravelBooking : BaseEntity
    {
        public int BookingId { get; set; }
        public string CustomerName { get; set; }
        public DateTime TravelDate { get; set; }
        public string Destination { get; set; }
        public decimal Price { get; set; }
    }
}
