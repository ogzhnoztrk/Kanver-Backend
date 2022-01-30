using Entities.Abstract;

namespace Entities.Concrete
{
    public class Faq : IEntity
    {
        public int FaqId { get; set; }
        public string Question { get; set; }
        public string Answer { get; set; }
    }
}
