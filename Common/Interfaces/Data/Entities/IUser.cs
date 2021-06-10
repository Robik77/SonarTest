using System.Collections.Generic;

namespace Data.Entities
{
    public interface IUser
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public ICollection<IUser> FormsCreated { get; set; }
        public ICollection<IUser> FormsPassed { get; set; }
    }
}
