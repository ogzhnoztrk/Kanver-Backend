using System.Collections.Generic;
using Business.Abstract;
using Core.Utilities.Results;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnnouncementController : ControllerBase
    {
        private readonly IAnnouncementService _announcementService;

        public AnnouncementController(IAnnouncementService announcementService)
        {
            _announcementService = announcementService;
        }


        [HttpPost("/postAnnouncement")]
        public IResult Add(Announcement announcement)
        {
            return _announcementService.Add(announcement);
        }

        [HttpDelete("/deleteAnnouncement")]
        public IResult Delete(Announcement announcement)
        {
            return _announcementService.Delete(announcement);
        }

        [HttpPut("/updateAnnouncement")]
        public IResult Update(Announcement announcement)
        {
            return _announcementService.Update(announcement);
        }

        [HttpGet("/getAllAnnouncement")]
        public IDataResult<List<Announcement>> GetAll()
        {
            return _announcementService.GetAll();
        }

        [HttpGet("/getAllAnnouncementByBloodType")]
        public IDataResult<List<Announcement>> GetAllByBloodType(int bloodType)
        {
            return _announcementService.GetAllByBloodType(bloodType);
        }

        [HttpGet("/getAllAnnouncementByCityId")]
        public IDataResult<List<Announcement>> GetAllByCityId(int cityId)
        {
            return _announcementService.GetAllByCityId(cityId);
        }
    }
}