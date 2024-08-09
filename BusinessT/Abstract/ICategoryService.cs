using CoreT.Helpers.Result.Abstract;
using EntitiesT.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessT.Abstract
{
    public interface ICategoryService
    {
        IResult Add(Category category);
        IResult Update(Category category);
        IResult Delete(int id);
        IDataResult<List<Category>> GetAllCategories();
        IDataResult<Category> Get(int id);
    }
}
