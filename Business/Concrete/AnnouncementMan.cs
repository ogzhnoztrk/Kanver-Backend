using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class AnnouncementMan : IAnnouncementService
    {
        private readonly IAnnouncementDal _announcementDal;

        public AnnouncementMan(IAnnouncementDal announcementDal)
        {
            _announcementDal = announcementDal;
        }


        public IResult Add(Announcement announcement)
        {
            _announcementDal.Add(announcement);
            return new SuccessResult("Eklendi");
        }

        public IResult Delete(Announcement announcement)
        {
            _announcementDal.Delete(announcement);
            return new SuccessResult("Eklendi");
        }

        public IResult Update(Announcement announcement)
        {
            _announcementDal.Update(announcement);
            return new SuccessResult("Eklendi");
        }
    }
}