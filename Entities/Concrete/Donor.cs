using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    class Donor : IEntity
    {
        public int UserId { get; set; } //Kullanıcı id'si one to many
        public int CityId { get; set; }
        public DateTime LastDonationDate { get; set; } //En son Kan verme tarihi
        public bool DisaeseStatus{ get; set; } //Hastalık bilgisi
        public bool DrugStatus{ get; set; } //Uyuşturucu bağımlılığı 
        public bool AlcholStatus{ get; set; } //Alkol Bağımlılığı
        public bool MedicationStatus { get; set; } //İlaç kullanma Durumu

    }
}
