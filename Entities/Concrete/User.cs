using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Entities.Abstract;

namespace Entities.Concrete
{
    public class User : IEntity
    {
        public int UserId { get; set; }
        [Range(1, 8)] public int BloodTypeId { get; set; } //Kan grubunun id'si
        public string Name { get; set; }
        public string LastName { get; set; }
        [EmailAddress] public string Email { get; set; }
        [DataType(DataType.PhoneNumber)]public string PhoneNumber { get; set; }
        [DataType(DataType.Password)]public string Password { get; set; }
        [Column(TypeName = "TINYINT")] public bool IsValidate { get; set; }
        [Column(TypeName = "TINYINT")] public bool IsMernisOk { get; set; }
        [StringLength(11)] public string IdentityNumber { get; set; }
        public DateTime BirthDay { get; set; }
    }
}