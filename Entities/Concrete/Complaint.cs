using System.ComponentModel.DataAnnotations;
using Entities.Abstract;

namespace Entities.Concrete
{
    public class Complaint : IEntity
    {
        public int ComplaintId { get; set; }
        public string ComplaintContent { get; set; }
        public string ComplaintSubject { get; set; }
        [EmailAddress] public string Email { get; set; }
        public string FullName { get; set; }
    }
}