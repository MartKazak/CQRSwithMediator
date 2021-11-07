using System.Collections.Generic;
using System.Linq;

namespace DemoApp.DataAccess.InMemory.InMemoryData
{
    public static class UsersList
    {
        private static readonly List<User> Users = new()
        {
            new User(1, "User", "In Memory One"),
            new User(2, "User", "In Memory Two"),
            new User(3, "User", "In Memory Three")
        };

        public static List<User> Get() => Users;

        public static User GetById(int id) => 
            Users.FirstOrDefault(u => u.Id == id);
    }
}
