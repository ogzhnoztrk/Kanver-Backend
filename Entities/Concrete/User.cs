using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    class User : IEntity
    {
        public int Id { get; set; }
        public int BloodTypeId { get; set; } //Kan grubunun id'si
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public bool IsValidate { get; set; }
        public bool IsMernisOk { get; set; }


    }
}
