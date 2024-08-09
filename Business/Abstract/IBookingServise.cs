using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;
namespace Business.Abstract
{
    public interface IBookingServise
    {
        void Add(TravelBooking booking);
        void Remove(TravelBooking booking);
        void Update(TravelBooking booking);
        List<TravelBooking> GetAll();
    }
}
