using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Conctrete
{
    public class EfDonorDal : EfEntityRepositoryBase<Donor, KanverDbsContext>, IDonorDal
    {
    }
}