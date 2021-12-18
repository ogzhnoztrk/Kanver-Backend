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
        public String Name { get; set; }
        public String Surname{ get; set; }
        public DateTime BirthDate { get; set; }
        public String BloodType { get; set; }

    }
}
