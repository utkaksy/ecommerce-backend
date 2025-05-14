using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;
        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public IResult Add(Category product)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(Category product)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Category>> GetAll()
        {
            return new SuccessDataResult<List<Category>>(_categoryDal.GetAll());
        }

        public IDataResult<Category> GetById(int productId)
        {
            throw new NotImplementedException();
        }

        public IResult Update(Category product)
        {
            throw new NotImplementedException();
        }
        //public List<Category> GetAll()
        //{
        //    return _categoryDal.GetAll();
        //}

        //public Category GetById(int categoryId)
        //{
        //    return _categoryDal.Get(c => c.CategoryId == categoryId);
        //}
    }
}
