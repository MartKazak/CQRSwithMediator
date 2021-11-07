using System.Collections.Generic;
using System.Linq;
using DemoApp.Domain.Entities;
using DemoApp.Types.Contracts.Users;

namespace DemoApp.DataAccess.EF.Users.Extensions
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

        public static List<UserDTO> MapToDTO(this IEnumerable<User> users) =>
            users.Select(u => u.MapToDTO()).ToList();
    }
}
