using BusinessT.Abstract;
using CoreT.Helpers.Result.Abstract;
using CoreT.Helpers.Result.Concrete;
using DataAccessT.Abstract;
using EntitiesT.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessT.Concrete
{
    public class BlogPostManager(IBlogPostDal blogPostDal, IUserDal userDal) : IBlogPostService
    {
        private readonly IBlogPostDal _blogPostDal = blogPostDal;
        private readonly IUserDal _userDal = userDal;

        public IResult Add(BlogPost blogPost)
        {
            
            var user = _userDal.Get(p=> p.ID==blogPost.UserID);
            if(user == null)
                {
                return new ErrorResult("user not found");
            }
            _blogPostDal.Add(blogPost);
            return new SuccessResult("success");
        }

        public IResult Delete(int id)
        {
            var blog = _blogPostDal.Get(p=> p.ID == id);
            if(blog == null)
            {
                return new ErrorResult("blog not found");
            }
            _blogPostDal.Delete(blog);
            return new SuccessResult("success");
        }

        public IDataResult<List<BlogPost>> GetAllBlogs()
        {
           var blogs = _blogPostDal.GetAll(p=> p.IsDelete==false);
            if (blogs.Count > 0)
            { return new SuccessDataResult<List<BlogPost>>(blogs,"successs");
                
            }
           return new ErrorDataResult<List<BlogPost>>(blogs, "error");
        }

        public IDataResult<BlogPost> Get(int id)
        {
            var blogs = _blogPostDal.Get(p => p.ID == id);
            if (blogs != null)
                return new SuccessDataResult<BlogPost>(blogs , "succces");
            else return new ErrorDataResult<BlogPost>(blogs, "erorr");
        }

        public IResult Update(BlogPost blogPost)
        {

            BlogPost blog;
            blog = _blogPostDal.Get(p=> p.ID==blogPost.ID && p.IsDelete==false);
             
            if (blog != null)
            {
                blog.Title = blogPost.Title;
                blog.Content = blogPost.Content;
                blog.IsDelete = blogPost.IsDelete;
                _blogPostDal.Update(blogPost);
                return new SuccessResult("successfully updated");
            }
            return new ErrorResult();
        }
    }
}
