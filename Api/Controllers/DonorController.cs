using System.Collections.Generic;
using Business.Abstract;
using Core.Utilities.Results;
using Entities.Concrete;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DonorController : ControllerBase
    {
        private readonly IDonorService _donorService;

        public DonorController(IDonorService donorService)
        {
            _donorService = donorService;
        }

      
        [HttpPost("/postDonor")]
        public IResult Add(Donor donor)
        {
            return _donorService.Add(donor);
        }

        [HttpPut("/updateDonor")]
        public IResult Update(Donor donor)
        {
            return _donorService.Update(donor);
        }

        [HttpDelete("/deleteDonor")]
        public IResult Delete(Donor donor)
        {
            return _donorService.Delete(donor);
        }

        [HttpGet("/getAllDonor")]
        public IDataResult<List<Donor>> GetAll()
        {
            return _donorService.GetAll();
        }

        [HttpGet("/getAllDonorByUserId")]
        public IDataResult<List<Donor>> GetAllByUserId(int userId)
        {
            var result = _donorService.GetAllByFilter(userId);
            return result;
        }
    }
}