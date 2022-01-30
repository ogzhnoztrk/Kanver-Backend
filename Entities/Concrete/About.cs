using System;
using Entities.Abstract;

namespace Entities.Concrete
{
    public class About : IEntity
    {
        public int AboutId { get; set; }

        public string Head{ get; set; }
        public string Content { get; set; }
    }
}
