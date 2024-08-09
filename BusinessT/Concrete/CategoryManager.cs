using BusinessT.Abstract;
using CoreT.Helpers.Result.Abstract;
using CoreT.Helpers.Result.Concrete;
using DataAccessT.Abstract;
using DataAccessT.Concrete;
using EntitiesT.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessT.Concrete
{
    public class CategoryManager(ICategoryDal categoryDal) : ICategoryService
    {
        private readonly ICategoryDal _categoryDal = categoryDal;

        public IResult Add(Category category)
        {
            if (category.CategoryName.Length > 4)
            {
                _categoryDal.Add(category);

                return new SuccessResult();
            }
            else
            {
                return new ErrorResult("minimum 4 herf");
            }
        }

        public IResult Delete(int id)
        {
            Category deleteCat = null;
            Category resultCat = _categoryDal.Get(p => p.IsDelete == false && p.ID == id);
            if (resultCat != null)
            {
                deleteCat = resultCat;
            }
            else
            {
                return new ErrorResult("Not found");
            }
            deleteCat.IsDelete = true;
            _categoryDal.Delete(deleteCat);
            return new SuccessResult("deleted");
        }

        public IDataResult<Category> Get(int id)
        {
               var cate = _categoryDal.Get(p=>p.ID == id);
              if (cate != null)
              {
                  return new SuccessDataResult<Category>(cate, "founddd");
              }
              return new ErrorDataResult<Category>("Not found bro"); 
            
        }

        public IDataResult<List<Category>> GetAllCategories()
        {
            var cate = _categoryDal.GetAll(p => p.IsDelete == false);
            if (cate.Count > 0)
            {
                return new SuccessDataResult<List<Category>>(cate, "found");
            }
            return new ErrorDataResult<List<Category>>(cate,"not found");
        }

        public IResult Update(Category category)
        {
            var updateCat = _categoryDal.Get(p=> p.IsDelete == false &&  p.ID == category.ID);
            if (updateCat != null)
            {
                updateCat.CategoryName = category.CategoryName;
                updateCat.IsDelete=category.IsDelete;
                _categoryDal.Update(updateCat);
                return new SuccessResult("update olundu");

            }
            return new ErrorResult("not found falan");
        }
    }
}
