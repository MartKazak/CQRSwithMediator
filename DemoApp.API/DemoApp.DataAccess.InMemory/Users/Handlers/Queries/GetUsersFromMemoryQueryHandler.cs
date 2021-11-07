using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using DemoApp.DataAccess.Abstractions;
using DemoApp.DataAccess.Contracts.Users;
using DemoApp.DataAccess.InMemory.InMemoryData;
using DemoApp.DataAccess.InMemory.Users.Extensions;
using DemoApp.DataAccess.Users.Queries;

namespace DemoApp.DataAccess.InMemory.Users.Handlers.Queries
{
    internal sealed class GetUsersFromMemoryQueryHandler : IQueryHandler<GetUsersFromMemoryQuery, List<UserDTO>>
    {
        public Task<List<UserDTO>> Handle(GetUsersFromMemoryQuery query, CancellationToken cancellationToken)
        {
            var users = UsersList.Get().MapToDTO();
            
            return Task.FromResult(users);
        }
    }
}
