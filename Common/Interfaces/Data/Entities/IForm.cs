using System;
using System.Collections.Generic;

namespace Data.Entities
{
    public interface IForm
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool IsTimeLimited { get; set; }
        public bool IsAnonymous { get; set; }
        public bool IsEditableAnswers { get; set; }
        public IUser Creator { get; set; }
        public ICollection<IUser> Users { get; set; }
        public ICollection<IPage> Pages { get; set; }
    }
}
