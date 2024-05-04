namespace AuthServer.Core
{
    public interface IUserService
    {
        Task<User> CreateUserAsync(User user);
        Task<User> GetUserByUsernameAsync(string username);
        // Add other user management methods as needed
    }
}
