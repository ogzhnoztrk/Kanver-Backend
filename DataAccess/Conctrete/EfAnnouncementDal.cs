using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace DataAccess.Conctrete
{
    public class EfAnnouncementDal : EfEntityRepositoryBase<Announcement, KanverDbsContext>, IAnnouncementDal
    {
       
    }
}