using System;
using Entities.Abstract;

namespace Entities.Concrete
{
    public class Contact : IEntity
    {
        public int  ContactId { get; set; }
        public string CompanyName { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

    }
}

