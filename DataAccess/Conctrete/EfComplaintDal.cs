using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Conctrete
{
    public class EfComplaintDal : EfEntityRepositoryBase<Complaint, KanverDbsContext>, IComplaintDal
    {
    }
}