namespace DemoApp.DataAccess.Contracts.Users
{
    //public sealed record UserDTO(int Id, string FirstName, string LastName);

    public sealed class UserDTO
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
