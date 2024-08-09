using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class EFBookingDal : IBookingDal
    {
        public void Add(TravelBooking entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(TravelBooking entity)
        {
            throw new NotImplementedException();
        }

        public TravelBooking Get(Expression<Func<TravelBooking, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<TravelBooking> GetAll(Expression<Func<TravelBooking, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(TravelBooking entity)
        {
            throw new NotImplementedException();
        }
    }
}
