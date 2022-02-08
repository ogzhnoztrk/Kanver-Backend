using System.Collections.Generic;
using Business.Abstract;
using Business.Adapters.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class AnnouncementMan : IAnnouncementService
    {
        private readonly IAnnouncementDal _announcementDal;
        private ISmsService _smsService;
        private IUserDal _userDal;
        public AnnouncementMan(IAnnouncementDal announcementDal, ISmsService smsService, IUserDal userDal)
        {
            _announcementDal = announcementDal;
            _smsService = smsService;
            _userDal = userDal;

        }


        public IResult Add(Announcement announcement)
        {

            _announcementDal.Add(announcement);
            SendSmsSameBloods(announcement.BloodTypeId);
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

        public IDataResult<List<Announcement>> GetAll()
        {
            return new SuccessDataResult<List<Announcement>>(_announcementDal.GetAll(), "Data Getirildi");
        }

        public IDataResult<List<Announcement>> GetAllByBloodType(int bloodType)
        {
            var result = _announcementDal.GetAllByFilter(a => a.BloodTypeId == bloodType);
            return new SuccessDataResult<List<Announcement>>(result, "Data Getirldi");
        }

        public IDataResult<List<Announcement>> GetAllByCityId(int cityId)
        {
            var result = _announcementDal.GetAllByFilter(a => a.CityId == cityId);
            return new SuccessDataResult<List<Announcement>>(result, "Data Getirldi");
        }

        private void SendSmsSameBloods(int announcementBloodId)
        {
            var result = _userDal.GetAllByFilter(user => announcementBloodId == user.BloodTypeId);
            foreach (var res in result)
            {
                _smsService.SendSms(res.PhoneNumber);
            }

        }
        
    }
}