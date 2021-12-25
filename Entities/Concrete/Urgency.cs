using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    class Urgency : IEntity
    {
        public int UrgencyId { get;}
        public int UrgencyDegree { get;}
    }
}
