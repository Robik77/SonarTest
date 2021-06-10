using System.Collections;
using System.Collections.Generic;

namespace Data.Entities
{
    public interface IBlock
    {
        public int Id { get; set; }
        public string Question { get; set; }
        public IPage Page { get; set; }
        public ICollection<IElement> Elements { get; set; }
        public IEnumerator GetEnumerator();
    }
}
