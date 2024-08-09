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
    public class BlogPostDal : BaseRepository<BlogPost, BaseContext>, IBlogPostDal
    {
        public BlogPostDal(BaseContext context) : base(context)
        {
            
        }
    }
}
