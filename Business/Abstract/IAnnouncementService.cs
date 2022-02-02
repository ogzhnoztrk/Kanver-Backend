using System.Collections.Generic;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IAnnouncementService
    {
        IResult Add(Announcement announcement);
        IResult Delete(Announcement announcement);
        IResult Update(Announcement announcement);
        IDataResult<List<Announcement>> GetAll();
        IDataResult<List<Announcement>> GetAllByBloodType(int bloodType);
        IDataResult<List<Announcement>> GetAllByCityId(int cityId);
    }
}