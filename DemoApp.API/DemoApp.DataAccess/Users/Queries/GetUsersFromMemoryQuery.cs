using System.Collections.Generic;
using DemoApp.DataAccess.Abstractions;
using DemoApp.DataAccess.Contracts.Users;

namespace DemoApp.DataAccess.Users.Queries
{
    public sealed class GetUsersFromMemoryQuery : IQuery<List<UserDTO>>
    {
    }
}
