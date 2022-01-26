using System.Collections.Generic;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IDonorService
    {
        IResult Add(Donor donor);
        IResult Update(Donor donor);
        IResult Delete(Donor donor);
        IDataResult<List<Donor>> GetAll();
        IDataResult<List<Donor>> GetAllByFilter(int userId);
    }
}