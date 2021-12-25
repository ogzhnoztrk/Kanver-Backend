using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    class AnnouncementType : IEntity
    {
        public int AnnouncementTypeId { get; set; }
        public int AnnouncementTypeName { get; set; }
    }
}
