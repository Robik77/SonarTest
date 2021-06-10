using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Entities
{
    public class Form
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        public string Description { get; set; }
        [Required]
        public DateTime CreationDate { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        [Required]
        public bool IsTimeLimited { get; set; }
        [Required]
        public bool IsAnonymous { get; set; }
        [Required]
        public bool IsEditableAnswers { get; set; }
        [Required]
        public User Creator { get; set; }
        public ICollection<User> Users { get; set; }
        [Required]
        public ICollection<Page> Pages { get; set; }
    }
}
