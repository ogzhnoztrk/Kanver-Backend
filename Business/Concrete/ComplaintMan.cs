using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class ComplaintMan : IComplaintService
    {
        private IComplaintDal _complaintDal;

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
