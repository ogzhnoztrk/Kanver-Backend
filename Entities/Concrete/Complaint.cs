using Entities.Abstract;

namespace Entities.Concrete
{
    public class Complaint : IEntity
    {
        public int ComplaintId { get; set; }
        public string ComplaintContent { get; set; }
    }
}