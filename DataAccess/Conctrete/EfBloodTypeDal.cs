using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Conctrete
{
    public class EfBloodTypeDal : EfEntityRepositoryBase<BloodType, KanverDbsContext>, IBloodTypeDal
    {
    }
}