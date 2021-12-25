using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    class Announcement :IEntity
    {
        public int AnnouncementId { get; set; }
        public int UserId { get; set; }
        public int BloodTypeId { get; set; }
        public int CityId { get; set; }
        public int UrgencyId { get; set; }
        public int AnnouncementTypeId { get; set; }
        
        public int MyProperty { get; set; }
        public DateTime AnnouncementDate { get; set; }
        public int Quantity { get; set; }
        
    }
}
