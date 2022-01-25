using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Conctrete
{
    public class EfCityDal : EfEntityRepositoryBase<City, KanverDbsContext>, ICityDal
    {
    }
}