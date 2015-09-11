using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using jack_oneTeamOneDreamDatabase;
using jack_oneTeamOneDreamEntities;

namespace jack_oneTeamOneDreamLogic
{
    public class OneTeamOneDreamLogic
    {
        private UnitOfWork _unitOfWork;
        private IGenericRepository<Product> _productRepository;
        public OneTeamOneDreamLogic()
        {
            _unitOfWork = new UnitOfWork();
            _productRepository = _unitOfWork.Repository<Product>();
        }

        public IList<Product>getAllProducts()
        {
            return _productRepository.GetAll();
        }

        public Product getProductById(int? id)
        {
            Expression<Func<Product, Boolean>> expression = buildExpression<Product>("Id", "=", id);
            return _productRepository.FindSingle(expression);

        }

        public Expression<Func<T, Boolean>> buildExpression<T>(string propertyName, string expression, object value)
        {
            ParameterExpression parameter = Expression.Parameter(typeof(T), "x");
            Expression prop = Expression.PropertyOrField(parameter, propertyName);
            Expression body;

            if(expression == "!=")
            {
                body = Expression.NotEqual(prop, Expression.Constant(value));
            }
            else
            {
                body = Expression.Equal(prop, Expression.Constant(value));
            }

             Expression<Func<T, Boolean>> lambda = Expression.Lambda<Func<T, bool>>(body, parameter);

             return lambda;
  
        }

        public void Dispose()
        {
            _unitOfWork.Dispose();
        }
    }
}
