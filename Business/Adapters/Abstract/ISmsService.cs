using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Adapters.Abstract
{
    public interface ISmsService
    {
        void SendSms(string PhoneNumber);
    }
}
