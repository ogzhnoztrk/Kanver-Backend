using System;
using Entities.Abstract;

namespace Entities.Concrete
{
    public class Donor : IEntity
    {
        public int DonorId { get; set; } //Kullanıcı id'si one to many
        public int UserId { get; set; }
        public int CityId { get; set; }
        public DateTime LastDonationDate { get; set; } //En son Kan verme tarihi
        public bool DiseaseStatus { get; set; } //Hastalık bilgisi
        public bool DrugStatus { get; set; } //Uyuşturucu bağımlılığı 
        public bool AlcholStatus { get; set; } //Alkol Bağımlılığı
        public bool MedicationStatus { get; set; } //İlaç kullanma Durumu
    }
}