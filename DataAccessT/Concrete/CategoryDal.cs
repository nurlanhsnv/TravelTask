using CoreT.DataAccess.Concrete;
using DataAccessT.Abstract;
using EntitiesT.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessT.Concrete
{
    public class CategoryDal : BaseRepository<Category, BaseContext>, ICategoryDal
    {
        public CategoryDal(BaseContext context): base(context) 
        {
            
        }
    }
}
