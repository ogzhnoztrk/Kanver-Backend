using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IAnnouncementService
    {
        IResult Add(Announcement announcement);
        IResult Delete(Announcement announcement);
        IResult Update(Announcement announcement);
    }
}