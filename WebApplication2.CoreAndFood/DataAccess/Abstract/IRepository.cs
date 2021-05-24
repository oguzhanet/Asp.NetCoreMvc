using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace WebApplication2.CoreAndFood.DataAccess.Abstract
{
    public interface IRepository<T>
    {
        List<T> GetAll(Expression<Func<T, bool>> filter);
        List<T> GetAll();
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);

    }
}
