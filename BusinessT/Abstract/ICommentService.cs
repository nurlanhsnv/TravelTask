using CoreT.Helpers.Result.Abstract;
using EntitiesT.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessT.Abstract
{
    public interface ICommentService
    {
        IResult Add(Comment comment);
        IResult Update(Comment user);
        IResult Delete(int id);
        IDataResult<List<Comment>> GetAllComments();
        IDataResult<Comment> Get(int id);
    }
}
