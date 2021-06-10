using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Data.Entities
{
    public class Block
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Question { get; set; }
        public Page Page { get; set; }
        [Required]
        public ICollection<Element> Elements { get; set; }
        public IEnumerator GetEnumerator()
        {
            return (IEnumerator)this;
        }
    }
}
