using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Data.Entities
{
    public class User : IdentityUser
    {
        [Required]
        public string Name { get; set; }
        public ICollection<Form> FormsCreated { get; set; }
        public ICollection<Form> FormsPassed { get; set; }
    }
}
