using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess.Abstract
{
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        //void DeleteById(int id);
        List<T> GetAll(Expression<Func<T, bool>> filter = null);
        List<T> GetAllByFilter(Expression<Func<T, bool>> filter);
    }
}