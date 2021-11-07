using DemoApp.DataAccess.Abstractions;
using DemoApp.DataAccess.Contracts.Users;

namespace DemoApp.DataAccess.Users.Queries
{
    //public sealed record GetUserByIdQuery(int UserId) : IQuery<UserDTO>;

    public sealed class GetUserByIdQuery : IQuery<UserDTO>
    {
        public GetUserByIdQuery(int id)
        {
            Id = id;
        }

        public int Id { get; }
        public string Type = "InMemory";
    }
}
