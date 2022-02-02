using Business.Abstract;
using Core.Utilities.Results;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

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
