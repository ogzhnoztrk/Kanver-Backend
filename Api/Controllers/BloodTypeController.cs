using System.Collections.Generic;
using Business.Abstract;
using Core.Utilities.Results;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BloodTypeController : ControllerBase
    {
        public IBloodTypeService _bloodtypeService;

        public BloodTypeController(IBloodTypeService bloodtypeService)
        {
            _bloodtypeService = bloodtypeService;
        }

        [HttpGet("/getAllBloodType")]
        public IDataResult<List<BloodType>> GetAll()
        {
            return _bloodtypeService.getAll();
        }
    }
}