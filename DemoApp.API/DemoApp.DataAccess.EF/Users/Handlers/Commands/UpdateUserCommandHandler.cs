using System;
using System.Threading;
using System.Threading.Tasks;
using DemoApp.DataAccess.Abstractions;
using DemoApp.DataAccess.Users.Commands;
using DemoApp.Domain.Repositories;
using MediatR;

namespace DemoApp.DataAccess.EF.Users.Handlers.Commands
{
    internal sealed class UpdateUserCommandHandler : ICommandHandler<UpdateUserCommand, Unit>
    {
        private readonly IUserRepository _userRepository;
        private readonly IUnitOfWork _unitOfWork;

        public UpdateUserCommandHandler(IUserRepository userRepository, IUnitOfWork unitOfWork)
        {
            _userRepository = userRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task<Unit> Handle(UpdateUserCommand command, CancellationToken cancellationToken)
        {
            var user = await _userRepository.GetByIdAsync(command.Id, cancellationToken);

            if (user is null)
                throw new ArgumentNullException(nameof(user), $"User by Id: {command.Id} was not found"); //TODO: use specific exception
            
            user.Update(command.FirstName, command.LastName);

            await _unitOfWork.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
