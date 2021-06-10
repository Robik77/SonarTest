using System.ComponentModel.DataAnnotations;

namespace Data.Entities
{
    public class FormUser
    {
        [Required]
        public int FormId { get; set; }
        [Required]
        public Form Form { get; set; }
        [Required]
        public int UserId { get; set; }
        [Required]
        public User User { get; set; }
    }
}
