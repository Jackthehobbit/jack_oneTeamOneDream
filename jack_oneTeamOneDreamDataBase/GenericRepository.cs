using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data;


namespace jack_oneTeamOneDreamDatabase
{
    public class GenericRepository<T> : IGenericRepository<T> where T: class 
    {
        private DbContext _context;

        public GenericRepository(DbContext Context)
        {
            this._context = Context;
        }

        public IList<T> GetAll()
        {
            IList<T> query = _context.Set<T>().ToList();
            return query;
        }
        public IList<T> FindBy(Expression<Func<T, bool>> expression)
        {
            IList<T> query = _context.Set<T>().Where(expression).ToList();
            return query;
        }
        public T FindSingle(Expression<Func<T, bool>> expression)
        {
            T query = _context.Set<T>().Where(expression).FirstOrDefault();
            return query;
        }
        public void Add(T entity)
        {
            _context.Set<T>().Add(entity);
        }
        public void Delete(T entity)
        {
            _context.Set<T>().Remove(entity);
        }
        public void Edit(T entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
        }
        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
