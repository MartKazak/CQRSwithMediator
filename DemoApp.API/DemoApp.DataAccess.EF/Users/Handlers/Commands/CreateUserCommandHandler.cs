using System.Threading;
using System.Threading.Tasks;
using DemoApp.DataAccess.EF.Users.Extensions;
using DemoApp.Domain.Entities;
using DemoApp.Domain.Repositories;
using DemoApp.Types.Abstractions;
using DemoApp.Types.Contracts.Users;
using DemoApp.Types.Users.Commands;

namespace DemoApp.DataAccess.EF.Users.Handlers.Commands
{
    internal sealed class CreateUserCommandHandler : ICommandHandler<CreateUserCommand, UserDTO>
    {
        private readonly IUserRepository _userRepository;
        private readonly IUnitOfWork _unitOfWork;

        public CreateUserCommandHandler(IUserRepository userRepository, IUnitOfWork unitOfWork)
        {
            _userRepository = userRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task<UserDTO> Handle(CreateUserCommand command, CancellationToken cancellationToken)
        {
            var user = new User(command.FirstName, command.LastName);

            _userRepository.Insert(user);

            await _unitOfWork.SaveChangesAsync(cancellationToken);

            return user.MapToDTO();
        }
    }
}
