using Services.ViewModels;
using System.Collections.Generic;

namespace Services.ViewMidels
{
    public class UserModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public IEnumerable<FormModel> Forms { get; set; }
    }
}
