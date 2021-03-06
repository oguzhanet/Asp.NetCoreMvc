using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using WebApplication2.CoreAndFood.DataAccess.Abstract;
using WebApplication2.CoreAndFood.Models.Entity;

namespace WebApplication2.CoreAndFood.DataAccess.Concrete.EntityFramework
{
    public class GenericRepository<T>: IRepository<T> where T:class
    {
        Context c = new Context();
        DbSet<T> _object;
        public GenericRepository()
        {
            _object = c.Set<T>();
        }

        public void Add(T entity)
        {
            var addedEntity = c.Entry(entity);
            addedEntity.State = EntityState.Added;
            c.SaveChanges();
        }

        public void Delete(T entity)
        {
            var deletedEntity = c.Entry(entity);
            deletedEntity.State = EntityState.Deleted;
            c.SaveChanges();
        }

        public T Get(Expression<Func<T, bool>> filter)
        {
            return _object.SingleOrDefault(filter);
        }

        public T Get(int id)
        {
            return _object.Find(id);
        }

        public List<T> GetAll(Expression<Func<T, bool>> filter)
        {
            return _object.Where(filter).ToList();
        }

        public List<T> GetAll()
        {
            return _object.ToList();
        }

        public void Update(T entity)
        {
            var updatedEntity = c.Entry(entity);
            updatedEntity.State = EntityState.Modified;
            c.SaveChanges();
        }

        public List<T> GetAll(string parameter)
        {
            return _object.Include(parameter).ToList();
        }
    }
}
