using System.Collections.Generic;
using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class AboutMan : IAboutService
    {
        private readonly IAboutDal _aboutDal;

        public AboutMan(IAboutDal aboutDal)
        {
            _aboutDal = aboutDal;
        }


        public IResult Add(About about)
        {
            _aboutDal.Add(about);
            return new SuccessResult("Eklendi");
        }

        public IResult Delete(About about)
        {
            _aboutDal.Delete(about);
            return new SuccessResult("Silindi");
        }

        public IDataResult<List<About>> GetAll()
        {
            return new SuccessDataResult<List<About>>(_aboutDal.GetAll(), "Data Getirildi");
        }
    }
}