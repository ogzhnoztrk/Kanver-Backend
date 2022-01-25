using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IDonorService
    {
        IResult Add(Donor donor);
        IResult Update(Donor donor);
        IResult Delete(Donor donor);
    }
}