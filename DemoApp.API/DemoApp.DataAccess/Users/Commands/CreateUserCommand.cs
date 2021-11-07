using DemoApp.DataAccess.Abstractions;
using DemoApp.DataAccess.Contracts.Users;

namespace DemoApp.DataAccess.Users.Commands
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
