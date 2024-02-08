using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using System.Collections.Generic;
using BlazorApp1.Models; // Assuming your models are in this namespace

namespace BlazorApp1.Services
{
    public class UserService : IUserService
    {
        private readonly HttpClient _httpClient;

        public UserService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<User>> GetUsers()
        {
            var response = await _httpClient.GetFromJsonAsync<UserResponse>("https://randomuser.me/api/?results=50");
            return response?.Results ?? new List<User>();
        }
    }
}