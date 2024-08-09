using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class BookingManager(IBookingDal bookingDal) : IBookingServise
    {
        public void Add(TravelBooking booking)
        {
            throw new NotImplementedException();
        }

        public List<TravelBooking> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Remove(TravelBooking booking)
        {
            throw new NotImplementedException();
        }

        public void Update(TravelBooking booking)
        {
            throw new NotImplementedException();
        }
    }
}
