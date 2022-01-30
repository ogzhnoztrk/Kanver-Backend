using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IFaqService
    {
        IResult Add(Faq faq );

        IResult Delete(Faq faq);
        IDataResult<List<Faq>> GetAll();

    }
}

