using System.Collections.Generic;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IAboutService
    {
        IResult Add(About about);

        IResult Delete(About about);
        IDataResult<List<About>> GetAll();
    }
}