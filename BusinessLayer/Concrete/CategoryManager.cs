using DataAccessLayer.Concrete.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;

namespace BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }
        public List<Category> GetList()
        {
            return _categoryDal.List();
        }

        public void Add(Category category)
        {
            _categoryDal.Add(category);
        }

        public void Update(Category category)
        {
            _categoryDal.Update(category);
        }

        public void Delete(Category category)
        {
            _categoryDal.Delete(category);
        }

        #region commentMethod
        // GenericRepository<Category> repository = new GenericRepository<Category>();
        //public List<Category> GetAll()
        //{
        //    return repository.List();
        //}

        //public void Add(Category category)
        //{
        //    if (category.Name == "" || category.Name.Length <= 3 || category.Description == "" || category.Name.Length >= 51)
        //    {
        //        //error message
        //    }
        //    else
        //    {
        //        repository.Add(category);
        //    }
        //}
        #endregion


    }
}
