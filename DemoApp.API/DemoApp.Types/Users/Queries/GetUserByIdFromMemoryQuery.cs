using DemoApp.Types.Abstractions;
using DemoApp.Types.Contracts.Users;

namespace DemoApp.Types.Users.Queries
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
