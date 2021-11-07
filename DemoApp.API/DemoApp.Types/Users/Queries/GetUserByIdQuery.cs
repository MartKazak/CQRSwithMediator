using DemoApp.Types.Abstractions;
using DemoApp.Types.Contracts.Users;

namespace DemoApp.Types.Users.Queries
{
    //public sealed record GetUserByIdQuery(int UserId) : IQuery<UserDTO>;

    public sealed class GetUserByIdQuery : IQuery<UserDTO>
    {
        public GetUserByIdQuery(int id)
        {
            Id = id;
        }

        public int Id { get; }
    }
}
