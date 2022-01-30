using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Conctrete
{
    public class EfFaqDal : EfEntityRepositoryBase<Faq, KanverDbsContext>, IFaqDal
    {
    }
}