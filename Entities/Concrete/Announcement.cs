using System;
using Entities.Abstract;

namespace Entities.Concrete
{
    public class Announcement : IEntity
    {
        public int AnnouncementId { get; set; }
        public int UserId { get; set; }
        public int BloodTypeId { get; set; }
        public int CityId { get; set; }
        public int UrgencyId { get; set; }
        public DateTime AnnouncementDate { get; set; }
        public int Quantity { get; set; }
    }
}