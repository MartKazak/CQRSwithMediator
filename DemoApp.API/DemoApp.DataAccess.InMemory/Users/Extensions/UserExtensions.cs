using System.Collections.Generic;
using System.Linq;
using DemoApp.DataAccess.InMemory.InMemoryData;
using DemoApp.Types.Contracts.Users;

namespace DemoApp.DataAccess.InMemory.Users.Extensions
{
    public static class UserExtensions
    {
        public static UserDTO MapToDTO(this User user) =>
            new()
            {
                Id = user.Id,
                FirstName = user.FirstName,
                LastName = user.LastName
            };

        public static List<UserDTO> MapToDTO(this List<User> users) =>
            users.Select(u => u.MapToDTO()).ToList();
    }
}
