using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;

namespace Business.Adapters.Abstract
{
    public interface IMernisServiceAdapter
    {
        Task<bool> VerifyCid(User user);
    }
}
