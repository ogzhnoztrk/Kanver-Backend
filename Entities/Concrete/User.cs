using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.Tracing;
using System.Security.Cryptography;
using Entities.Abstract;

namespace Entities.Concrete
{

    public class User : IEntity
    {

        //[Key]

        // [DatabaseGenerated(DatabaseGeneratedOption.Identity)] 

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] 
        public int UserId { get; set; } 
       public int BloodTypeId { get; set; } //Kan grubunun id'si
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Password { get; set; }
        public bool IsValidate { get; set; }
        public bool IsMernisOk { get; set; }
        public string IdentityNumber { get; set; }
        public DateTime BirthDay { get; set; }

        //  [Key]
        // public int iduser { get; set; }
        // public int fk_blood_type { get; set; } //Kan grubunun id'si
        // public string name { get; set; }
        // public string surname { get; set; }
        // public string email { get; set; }
        // public string phone_number { get; set; }
        // public bool is_validate { get; set; }
        // public bool is_mernis_ok { get; set; }
        //
        
    }
}