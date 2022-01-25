using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IComplaint
    {
        IResult Add(Complaint complaint);
        IResult Delete(Complaint complaint);
    }
}