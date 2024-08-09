using DataAccessT.Abstract;
using BusinessT.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntitiesT.Concrete;
using CoreT.Helpers.Result.Abstract;
using CoreT.Helpers.Result.Concrete;

namespace BusinessT.Concrete
{
    public class CommentManager(ICommentDal commentDal, IBlogPostDal blogPostDal, IUserDal userDal) : ICommentService
    {
        private readonly ICommentDal _commentDal = commentDal;
        private readonly IBlogPostDal _blogPostDal = blogPostDal;
        private readonly IUserDal _userDal = userDal;
        public IResult Add(Comment comment)
        {
            var user = _userDal.Get(p => p.ID == comment.UserId);
            var blog = _blogPostDal.Get(p => p.ID == comment.UserId);
            if (user== null && blog ==null)
            {
                return new ErrorResult("user or blog id not found");
            }
            _commentDal.Add(comment);
            return new SuccessResult("comment add olundu");
        }
        public IResult Delete(int id)
        {
            var comm = _commentDal.Get(p=> p.ID==id);
            if (comm==null)
            {
                return new ErrorResult("comment not found");
            }
            _commentDal.Delete(comm);
            return new SuccessResult("delete olundu ..");
        }

        public IDataResult<List<Comment>> GetAllComments()
        {
            var comm = _commentDal.GetAll(p => p.IsDelete == false);
            if (comm.Count > 0)
            {
                return new SuccessDataResult<List<Comment>>(comm, "successs");

            }
            return new ErrorDataResult<List<Comment>>(comm, "error");
        }

        public IDataResult<Comment> Get(int id)
        {
            var comm = _commentDal.Get(p => p.ID == id);
            if (comm != null)
                return new SuccessDataResult<Comment>(comm ,"succces");
            else return new ErrorDataResult<Comment>(comm, "erorr");
        }

        public IResult Update(Comment comment)
        {
            Comment comm;
            comm = _commentDal.Get(p => p.ID == comment.ID && p.IsDelete == false);
           
            if (comm != null )
            {
                comm.Content = comment.Content;
                comm.Comments = comment.Comments;
                comm.IsDelete = comment.IsDelete;
                _commentDal.Update(comm);
                return new SuccessResult("successfully updated");
            }
            return new ErrorResult();
        }

         
    }
}
