using System.Collections.Generic;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface ICityService
    {
        IDataResult<List<City>> getAll();
        IResult getCityNameById(int cityID);
    }
}