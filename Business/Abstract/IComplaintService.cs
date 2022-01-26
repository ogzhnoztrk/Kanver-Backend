using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
