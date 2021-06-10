using Data.Entities;
using System.Linq;

namespace Data
{
    public static class DbInitializer
    {
        private static void InitializeUsers(DataContext context)
        {
            if (context.Users.Any())
            {
                return;
            }
            context.Users.AddRange(new User[] {
                new User() { Name = "User 1", Email = "user1@example.com" },
                new User() { Name = "User 2", Email = "user2@example.com" },
                new User() { Name = "User 3", Email = "user3@example.com" },
                new User() { Name = "User 4", Email = "user4@example.com" }
            });
            context.SaveChanges();
        }
        public static void Initialize(DataContext context)
        {
            InitializeUsers(context);          
        }
    }
}
