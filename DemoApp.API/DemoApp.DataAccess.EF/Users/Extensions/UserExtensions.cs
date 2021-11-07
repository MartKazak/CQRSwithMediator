using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoApp.DataAccess.Contracts.Users;
using DemoApp.Domain.Entities;

namespace DemoApp.DataAccess.EF.Users.Extensions
{
    //TODO: move to DataAccess if will be same for other proj.
    public static class UserExtensions
    {
        public static UserDTO MapToDTO(this User user) =>
            new UserDTO
            {
                Id = user.Id,
                FirstName = user.FirstName,
                LastName = user.LastName
            };

        public static List<UserDTO> MapToDTO(this IEnumerable<User> users) =>
            users.Select(u => u.MapToDTO()).ToList();
    }
}
