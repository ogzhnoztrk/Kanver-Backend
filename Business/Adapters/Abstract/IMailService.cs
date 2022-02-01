using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Utilities.Results;
using Entities.Abstract;
using Entities.Concrete;

namespace Business.Adapters.Abstract
{
    public interface IMailService
    {
        void SendMailForPassword(User user);
    }
}
