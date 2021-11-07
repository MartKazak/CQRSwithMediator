using System.Collections.Generic;
using DemoApp.DataAccess.Abstractions;
using DemoApp.DataAccess.Contracts.Users;

namespace DemoApp.DataAccess.Users.Queries
{

    //public sealed record GetUsersQuery() : IQuery<List<UserDTO>>;
    public sealed class GetUsersQuery : IQuery<List<UserDTO>>
    {
    }
}
