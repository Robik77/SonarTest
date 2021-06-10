using Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Linq;

namespace Data.Repositiories
{
    public class UserRepository
    {
        readonly DataContext context;
        public UserRepository()
        {
            context = new DataContext();
            DbInitializer.Initialize(context);
        }
        public IEnumerable<User> Get()
        {
            var users = context.Users.ToList();
            return users;
        }
        public User GetUserById(string id)
        {
            return context.Users.FirstOrDefault(x => x.Id == id);
        }
    }
}
