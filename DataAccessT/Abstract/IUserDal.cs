﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoreT.DataAccess.Abstract;
using EntitiesT.Concrete;

namespace DataAccessT.Abstract
{
    public interface IUserDal : IBaseRepository<User>
    {

    }
}
