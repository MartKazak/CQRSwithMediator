using DemoApp.DataAccess.Abstractions;
using MediatR;

namespace DemoApp.DataAccess.Users.Commands
{
    //public sealed record UpdateUserCommand(int UserId, string FirstName, string LastName) : ICommand<Unit>;

    public sealed class UpdateUserCommand : ICommand<Unit>
    {
        public UpdateUserCommand(int id, string firstName, string lastName)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
        }

        public int Id { get; set; } //needed only for api request. Create a new layer to separate request from command
        public string FirstName { get; }
        public string LastName { get; }
    }
}
