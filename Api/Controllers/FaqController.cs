using System.Collections.Generic;
using Business.Abstract;
using Core.Utilities.Results;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FaqController : ControllerBase
    {
        private readonly IFaqService _faqService;

        public FaqController(IFaqService faqService)
        {
            _faqService = faqService;
        }

        [HttpPost("/addFaq")]
        public IResult Add(Faq faq)
        {
            return _faqService.Add(faq);
        }

        [HttpDelete("/deleteFaq")]
        public IResult Delete(Faq faq)
        {
            return _faqService.Delete(faq);
        }

        [HttpGet("/getAllFaq")]
        public IDataResult<List<Faq>> GetAll()
        {
            return _faqService.GetAll();
        }
    }
}