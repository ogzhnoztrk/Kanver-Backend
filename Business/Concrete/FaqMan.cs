using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class FaqMan : IFaqService
    {
        private IFaqDal _faqDal;

        public FaqMan(IFaqDal faqDal)
        {
            _faqDal = faqDal;
        }


        public IResult Add(Faq faq)
        {
            _faqDal.Add(faq);
            return new SuccessResult("Eklendi");
        }

        public IResult Delete(Faq faq)
        {
            _faqDal.Delete(faq);
            return new SuccessResult("Silindi");
        }

        public IDataResult<List<Faq>> GetAll()
        {
            return new SuccessDataResult<List<Faq>>(_faqDal.GetAll(), "Data Getirildi");
        }
    }
}