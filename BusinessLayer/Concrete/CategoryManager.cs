using DataAccessLayer.Concrete.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager
    {
        GenericRepository<Category> repository = new GenericRepository<Category>();

        public List<Category> GetAll()
        {
            return repository.List();
        }

        public void Add(Category category)
        {
            if (category.Name == "" || category.Name.Length <= 3 || category.Description == "" || category.Name.Length >= 51)
            {
                //error message
            }
            else
            {
                repository.Add(category);
            }
        }
    }
}
