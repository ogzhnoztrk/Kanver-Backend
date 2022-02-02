using System.Collections.Generic;
using Business.Abstract;
using Core.Utilities.Results;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ComplaintController : ControllerBase
    {
        private readonly IComplaintService _complaintService;

        public ComplaintController(IComplaintService complaintService)
        {
            _complaintService = complaintService;
        }

        [HttpPost("/postComplaint")]
        public IResult Add(Complaint complaint)
        {
            return _complaintService.Add(complaint);
        }

        [HttpDelete("/deleteComplaint")]
        public IResult Delete(Complaint complaint)
        {
            return _complaintService.Delete(complaint);
        }

        [HttpGet("/getAllComplaint")]
        public IDataResult<List<Complaint>> GetAll()
        {
            return _complaintService.GetAll();
        }
    }
}