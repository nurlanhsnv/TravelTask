using CoreT.Helpers.Result.Abstract;
using EntitiesT.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessT.Abstract
{
    public interface IBlogPostService
    {
        IResult Add(BlogPost blogPost);
        IResult Update(BlogPost blogPost);
        IResult Delete(int id);
        IDataResult<List<BlogPost>> GetAllBlogs();
        IDataResult<BlogPost> Get(int id);
    }
}
