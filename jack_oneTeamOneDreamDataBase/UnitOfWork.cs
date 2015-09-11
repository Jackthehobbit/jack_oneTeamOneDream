using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using jack_oneTeamOneDreamEntities;

namespace jack_oneTeamOneDreamDatabase
{
    public class UnitOfWork 
    {
        private readonly DbContext _context;
        private Dictionary<string,object> repositories;

        public UnitOfWork(DbContext Context)
        {
            this._context = Context;
        }

        public UnitOfWork()
        {
            this._context = new DataBaseContext();
        }

        public IGenericRepository<T> Repository<T>() where T : class
        {
            if ( repositories == null)
            {
                repositories = new Dictionary<string, object>();
            }

            string key = typeof(T).Name;

            if(!repositories.ContainsKey(key))
            {
                var repositoryType = typeof(GenericRepository<>);
                var repositoryInstance = Activator.CreateInstance(repositoryType.MakeGenericType(typeof(T)), _context);
                repositories.Add(key, repositoryInstance);
            }
            return (GenericRepository<T>)repositories[key];
        }       

        public void Save(){
            _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
