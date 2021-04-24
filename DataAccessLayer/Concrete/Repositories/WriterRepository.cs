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
    public class WriterRepository : IWriterDal
    {
        ProjeDbContext context = new ProjeDbContext();
        DbSet<Writter> _writer;

        public void Add(Writter entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Writter entity)
        {
            throw new NotImplementedException();
        }

        public List<Writter> List()
        {
            throw new NotImplementedException();
        }

        public List<Writter> List(Expression<Func<Writter, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Update(Writter entity)
        {
            throw new NotImplementedException();
        }
    }
}
