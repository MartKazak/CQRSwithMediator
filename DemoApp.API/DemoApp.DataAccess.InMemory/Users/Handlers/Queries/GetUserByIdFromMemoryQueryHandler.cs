using System;
using System.Threading;
using System.Threading.Tasks;
using DemoApp.DataAccess.Abstractions;
using DemoApp.DataAccess.Contracts.Users;
using DemoApp.DataAccess.InMemory.InMemoryData;
using DemoApp.DataAccess.InMemory.Users.Extensions;
using DemoApp.DataAccess.Users.Queries;

namespace DemoApp.DataAccess.InMemory.Users.Handlers.Queries
{
    public class GetUserByIdFromMemoryQueryHandler : IQueryHandler<GetUserByIdFromMemoryQuery, UserDTO>
    {
        public Task<UserDTO> Handle(GetUserByIdFromMemoryQuery query, CancellationToken cancellationToken)
        {
            var user = UsersList.GetById(query.Id);

            if (user is null)
                throw new ArgumentNullException(nameof(user), $"User by Id: {query.Id} was not found"); //TODO: use specific exception

            return Task.FromResult(user.MapToDTO());
        }
    }
}
