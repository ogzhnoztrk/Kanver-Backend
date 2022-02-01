using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Entities.Abstract;

namespace Entities.Concrete
{
    public class Donor : IEntity
    {
        public int DonorId { get; set; } //Kullanıcı id'si one to many
        [ForeignKey("User")]public int UserId { get; set; }
        [Range(1,81)]public int CityId { get; set; }
        [Column(TypeName = "TINYINT")] public bool DiseaseStatus { get; set; } //Hastalık bilgisi
        [Column(TypeName = "TINYINT")] public bool DrugStatus { get; set; } //Uyuşturucu bağımlılığı 
        [Column(TypeName = "TINYINT")] public bool AlcholStatus { get; set; } //Alkol Bağımlılığı
        [Column(TypeName = "TINYINT")] public bool MedicationStatus { get; set; } //İlaç kullanma Durumu
    }
}