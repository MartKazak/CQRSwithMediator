using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using DemoApp.DataAccess.InMemory.InMemoryData;
using DemoApp.DataAccess.InMemory.Users.Extensions;
using DemoApp.Types.Abstractions;
using DemoApp.Types.Contracts.Users;
using DemoApp.Types.Users.Queries;

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
