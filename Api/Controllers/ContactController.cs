using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private IContactService _contactService;

        public ContactController(IContactService contactService)
        {
            _contactService = contactService;
        }

        [HttpPost("/postContact")]
        public IResult Add(Contact contact)
        {
            return _contactService.Add(contact);
        }

        [HttpDelete("/deleteContact")]
        public IResult Delete(Contact contact)
        {
            return _contactService.Delete(contact);
        }

        [HttpGet("/getAllContact")]
        public IDataResult<List<Contact>> GetAll()
        {
            return _contactService.GetAll();
        }
    }
}
