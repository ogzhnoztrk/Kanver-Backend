using System.ComponentModel.DataAnnotations;
using Entities.Abstract;

namespace Entities.Concrete
{
    public class BloodType : IEntity
    {
        public int BloodTypeId { get; set; }

        public string BloodTypeName { get; set; }


    }
}