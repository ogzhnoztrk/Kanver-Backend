using Entities.Abstract;

namespace Entities.Concrete
{
    public class About : IEntity
    {
        public int AboutId { get; set; }
        public string Content1 { get; set; }
        public string Content2 { get; set; }
        public string Content3 { get; set; }
    }
}
