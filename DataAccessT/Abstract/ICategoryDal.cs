﻿using CoreT.DataAccess.Abstract;
using EntitiesT.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessT.Abstract
{
    public interface ICategoryDal : IBaseRepository<Category>
    {
    }
}
