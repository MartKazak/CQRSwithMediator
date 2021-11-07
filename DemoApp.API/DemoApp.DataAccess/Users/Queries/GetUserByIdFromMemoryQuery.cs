using DemoApp.DataAccess.Abstractions;
using DemoApp.DataAccess.Contracts.Users;

namespace DemoApp.DataAccess.Users.Queries
{
    public class GetUserByIdFromMemoryQuery : IQuery<UserDTO>
    {
        public GetUserByIdFromMemoryQuery(int id)
        {
            Id = id;
        }

        public int Id { get; }
    }
}
