using System.Collections.Generic;
using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class BloodTypeMan : IBloodTypeService
    {
        public IBloodTypeDal _bloodtypeDal;

        public BloodTypeMan(IBloodTypeDal bloodtypeDal)
        {
            _bloodtypeDal = bloodtypeDal;
        }

        public IDataResult<List<BloodType>> getAll()
        {
            return new SuccessDataResult<List<BloodType>>(_bloodtypeDal.GetAll(), "getirildi");
        }
    }
}