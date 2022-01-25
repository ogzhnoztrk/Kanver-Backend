using Core.DataAccess.EntityFramework;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace DataAccess.Conctrete
{
    public class EfUserDal : EfEntityRepositoryBase<User, KanverDbsContext>, IUserDal
    {
        
    }

}