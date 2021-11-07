using System.Collections.Generic;
using DemoApp.Types.Abstractions;
using DemoApp.Types.Contracts.Users;

namespace DemoApp.Types.Users.Queries
{

    //public sealed record GetUsersQuery() : IQuery<List<UserDTO>>;
    public sealed class GetUsersQuery : IQuery<List<UserDTO>>
    {
    }
}
