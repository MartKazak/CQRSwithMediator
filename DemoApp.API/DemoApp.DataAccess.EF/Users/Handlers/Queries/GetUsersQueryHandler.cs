using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using DemoApp.DataAccess.EF.Users.Extensions;
using DemoApp.Domain.Repositories;
using DemoApp.Types.Abstractions;
using DemoApp.Types.Contracts.Users;
using DemoApp.Types.Users.Queries;

namespace DemoApp.DataAccess.EF.Users.Handlers.Queries
{
    internal sealed class GetUsersQueryHandler : IQueryHandler<GetUsersQuery, List<UserDTO>>
    {
        private readonly IUserRepository _userRepository;

        public GetUsersQueryHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<List<UserDTO>> Handle(GetUsersQuery query, CancellationToken cancellationToken)
        {
            var users = await _userRepository.GetAsync(cancellationToken);

            return users.MapToDTO();
        }
    }
}
