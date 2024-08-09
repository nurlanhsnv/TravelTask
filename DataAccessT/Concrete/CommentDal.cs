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
    public class CommentDal : BaseRepository<Comment, BaseContext>, ICommentDal
    {
        public CommentDal(BaseContext context) : base(context)
        {

        }
    }
}
