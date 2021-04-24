using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.Repositories
{
    public class CategoryRepository:ICategoryDal
    {
        ProjeDbContext context = new ProjeDbContext();
        DbSet<Category> _category;

        public void Add(Category category)
        {
            _category.Add(category);
            context.SaveChanges();
        }

        public void Delete(Category category)
        {
            _category.Remove(category);
            context.SaveChanges();
        }

        public List<Category> List()
        {
            return _category.ToList();
        }

        public List<Category> List(Expression<Func<Category, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Update(Category category)
        {
            context.SaveChanges();
        }
    }
}
