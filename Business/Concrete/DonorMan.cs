using System.Collections.Generic;
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
            if (donor.AlcholStatus && donor.DiseaseStatus && donor.DrugStatus && donor.MedicationStatus)
            {
                _donorDal.Add(donor);
                return new SuccessResult("Donor Eklendi");
            }
            else
            {
                return new ErrorResult(message: "Kullanıcının Değerleri Donor Olmayı Karşılamıyor");
            }
            
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

        public IDataResult<List<Donor>> GetAll()
        {
            return new SuccessDataResult<List<Donor>>(_donorDal.GetAll(), "DataGetirildi");
        }

        public IDataResult<List<Donor>> GetAllByFilter(int userId)
        {
            var result = _donorDal.GetAllByFilter(d => d.UserId == userId);
            return new SuccessDataResult<List<Donor>>(result, "Data Getirildi");
        }

     
    }
}