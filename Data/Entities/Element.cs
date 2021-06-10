using System.ComponentModel.DataAnnotations;

namespace Data.Entities
{
    public class Element
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public Attribute Attribute { get; set; }
        public string Description { get; set; }
        public Block Block { get; set; }
    }
}
