using DemoApp.Types.Abstractions;
using DemoApp.Types.Contracts.Users;

namespace DemoApp.Types.Users.Commands
{
    //public sealed record CreateUserCommand(string FirstName, string LastName) : ICommand<UserDTO>;

    public sealed class CreateUserCommand : ICommand<UserDTO>
    {
        public CreateUserCommand(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public string FirstName { get; }
        public string LastName { get; }
    }
}
