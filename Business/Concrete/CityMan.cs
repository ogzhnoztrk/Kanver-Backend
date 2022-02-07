using System.Collections.Generic;
using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class CityMan : ICityService
    {
        public ICityDal _cityDal;

        public CityMan(ICityDal cityDal)
        {
            _cityDal = cityDal;
        }

        public IDataResult<List<City>> getAll()
        {
            return new SuccessDataResult<List<City>>(_cityDal.GetAll(), "getirildi");
        }

        public IResult getCityNameById(int cityID)
        {
            var result = _cityDal.Get(c => cityID == c.CityId);
            return new SuccessDataResult<City>(result,"Şehir Getirildi");
        }
    }
}