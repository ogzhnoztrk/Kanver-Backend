using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Conctrete
{
    public class EfContactDal : EfEntityRepositoryBase<Contact, KanverDbsContext>, IContactDal
    {
    }
}