using BlazorApp1.Models;

namespace BlazorApp1.Services
{
    public interface IUserService
    {
        Task<IEnumerable<User>> GetUsers();
    }
}
