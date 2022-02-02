using System.Collections.Generic;
using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class ComplaintMan : IComplaintService
    {
        private readonly IComplaintDal _complaintDal;

        public ComplaintMan(IComplaintDal complaintDal)
        {
            _complaintDal = complaintDal;
        }


        public IResult Add(Complaint complaint)
        {
            _complaintDal.Add(complaint);
            return new SuccessResult("Eklendi");
        }

        public IResult Delete(Complaint complaint)
        {
            _complaintDal.Delete(complaint);
            return new SuccessResult("Silindi");
        }

        public IDataResult<List<Complaint>> GetAll()
        {
            return new SuccessDataResult<List<Complaint>>(_complaintDal.GetAll(), "Data Getirildi");
        }
    }
}