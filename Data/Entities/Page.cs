using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Data.Entities
{
    public class Page
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int Number { get; set; }
        public Form Form { get; set; }
        [Required]
        public ICollection<Block> Blocks { get; set; }
    }
}
