﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Entities.Abstract;

namespace DataAccess.Abstract
{
    //public interface IEntityRepository<T>
    //{
    //    IList<T> GetList(Expression<Func<T, bool>> filter = null);
    //    T Get(Expression<Func<T, bool>> filter);
    //    void Add(T entity);
    //    void Update(T entity);
    //    void Delete(T entity);
    //    void asdasd();    }
    public interface IEntityRepository<T>// where T : class, IEntity, new()
    {
        T Get(Expression<Func<T, bool>> filter);
       
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}