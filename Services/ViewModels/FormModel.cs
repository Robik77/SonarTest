using Services.ViewMidels;
using System;
using System.Collections.Generic;

namespace Services.ViewModels
{
    public class FormModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string IsLimited { get; set; }
        public bool IsAnonymous { get; set; }
        public bool IsEditableAnswers { get; set; }
        public UserModel Creator { get; set; }
        public IEnumerable<UserModel> Users { get; set; }
    }
}
