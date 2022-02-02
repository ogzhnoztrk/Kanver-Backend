using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Conctrete
{
    public class EfAnnouncementDal : EfEntityRepositoryBase<Announcement, KanverDbsContext>, IAnnouncementDal
    {
    }
}