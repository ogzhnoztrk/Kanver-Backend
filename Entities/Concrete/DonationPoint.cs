using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    class DonationPoint : IEntity
    {
        public int DonationPointId { get; set; }
        public int CityId { get; set; }
        public string Adress { get; set; }
    }
}
