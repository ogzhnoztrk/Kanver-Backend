using System.Collections.Generic;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IComplaintService
    {
        IResult Add(Complaint complaint);

        IResult Delete(Complaint complaint);
        IDataResult<List<Complaint>> GetAll();
    }
}