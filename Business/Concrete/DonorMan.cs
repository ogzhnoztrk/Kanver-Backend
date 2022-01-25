using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class DonorMan : IDonorService
    {
        private readonly IDonorDal _donorDal;

        public DonorMan(IDonorDal donorDal)
        {
            _donorDal = donorDal;
        }

        public IResult Add(Donor donor)
        {
            _donorDal.Add(donor);
            return new SuccessResult("Donor Eklendi");
        }

        public IResult Update(Donor donor)
        {
            _donorDal.Update(donor);
            return new SuccessResult("Donor Güncellendi");
        }

        public IResult Delete(Donor donor)
        {
            _donorDal.Delete(donor);
            return new SuccessResult("Donor Silindi");
        }
    }
}