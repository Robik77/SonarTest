using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Data.Entities
{
    public interface IPage
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public IForm Form { get; set; }
        public ICollection<IBlock> Blocks { get; set; }
    }
}
