using System.Collections.Generic;
using Business.Abstract;
using Core.Utilities.Results;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutController : ControllerBase
    {
        private readonly IAboutService _aboutService;

        public AboutController(IAboutService aboutService)
        {
            _aboutService = aboutService;
        }

        [HttpPost("/postAbout")]
        public IResult Add(About about)
        {
            return _aboutService.Add(about);
        }

        [HttpDelete("/deleteAbout")]
        public IResult Delete(About about)
        {
            return _aboutService.Delete(about);
        }

        [HttpGet("/getAllAbout")]
        public IDataResult<List<About>> GetAll()
        {
            return _aboutService.GetAll();
        }
    }
}