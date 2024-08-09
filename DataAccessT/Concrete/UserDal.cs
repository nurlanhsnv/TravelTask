using CoreT.DataAccess.Concrete;
using DataAccessT.Abstract;
using EntitiesT.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessT.Concrete
{
    public class UserDal : BaseRepository<User, BaseContext>, IUserDal
    {
        public UserDal(BaseContext context) : base(context)
        {

        }
    }
}
