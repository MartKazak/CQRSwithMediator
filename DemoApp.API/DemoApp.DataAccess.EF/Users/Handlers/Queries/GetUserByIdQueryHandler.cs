using System;
using System.Threading;
using System.Threading.Tasks;
using DemoApp.DataAccess.EF.Users.Extensions;
using DemoApp.Domain.Repositories;
using DemoApp.Types.Abstractions;
using DemoApp.Types.Contracts.Users;
using DemoApp.Types.Users.Queries;

namespace DemoApp.DataAccess.EF.Users.Handlers.Queries
{
    internal sealed class GetUserByIdQueryHandler : IQueryHandler<GetUserByIdQuery, UserDTO>
    {
        private readonly IUserRepository _userRepository;

        public GetUserByIdQueryHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<UserDTO> Handle(GetUserByIdQuery query, CancellationToken cancellationToken)
        {
            var user = await _userRepository.GetByIdAsync(query.Id, cancellationToken);

            if (user is null)
                throw new ArgumentNullException(nameof(user), $"User by Id: {query.Id} was not found"); //TODO: use specific exception

            return user.MapToDTO();
        }
    }
}
