using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using jack_oneTeamOneDreamEntities;

namespace jack_oneTeamOneDreamDatabase
{
    public interface IGenericRepository<T> where T: class 
    {
        IList<T> GetAll();
        IList<T> FindBy(Expression<Func<T, bool>> expression);
        T FindSingle(Expression<Func<T, bool>> expression);
        void Add(T entity);
        void Delete(T entity);
        void Edit(T entity);
        void Save();
    }
}
