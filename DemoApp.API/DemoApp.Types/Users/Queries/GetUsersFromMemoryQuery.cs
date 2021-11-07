using System.Collections.Generic;
using DemoApp.Types.Abstractions;
using DemoApp.Types.Contracts.Users;

namespace DemoApp.Types.Users.Queries
{
    public sealed class GetUsersFromMemoryQuery : IQuery<List<UserDTO>>
    {
    }
}
