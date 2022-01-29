

using System;
using System.Linq;
using System.Linq.Expressions;
using Core.DataAccess.Abstract;
using DataAccess.Conctrete;
using Entities.Concrete;

namespace DataAccess.Abstract
{
    public interface IUserDal : IEntityRepository<User>
    {
      
    }
}