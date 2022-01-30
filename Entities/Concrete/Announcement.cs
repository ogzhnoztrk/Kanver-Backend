using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Entities.Abstract;

namespace Entities.Concrete
{
    public class Announcement : IEntity
    {
        [Key]public int AnnouncementId { get; set; }
        [ForeignKey("BloodType")][Range(1,8)]public int BloodTypeId { get; set; }
        public int CityId { get; set; }
        public int Urgency { get; set; }
        public DateTime AnnouncementDate { get; set; }
        
        public string PhoneNumber{ get; set; }
        public string Explanation { get; set; }
    }
}