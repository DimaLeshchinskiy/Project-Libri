using Microsoft.AspNetCore.Http;
using ProjectLibri.Graph;
using ProjectLibri.Models;
using System.Diagnostics;
using System.Security.Claims;
using System.Text.Json;
using System.Threading.Tasks;

namespace ProjectLibri.Service
{
    public class UserService : IUserService
    {
        private readonly IGraphServiceClientFactory _graphServiceClientFactory;

        public UserService(IGraphServiceClientFactory graphServiceClientFactory)
        {
            _graphServiceClientFactory = graphServiceClientFactory;
        }

        public async Task<User> GetUser(HttpContext HttpContext)
        {

            var user = HttpContext.User;

            if (!user.Identity.IsAuthenticated)
                return null;

            // Get users's email.
            string email = user.FindFirst("preferred_username")?.Value;

            // Initialize the GraphServiceClient.
            var graphClient = _graphServiceClientFactory.GetAuthenticatedGraphClient((ClaimsIdentity)user.Identity);

            string json = await GraphService.GetUserJson(graphClient, email, HttpContext);
            //string base64 = await GraphService.GetPictureBase64(graphClient, email, HttpContext);

            var options = new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                WriteIndented = true
            };

            User graphUser = JsonSerializer.Deserialize<User>(json, options);

            return graphUser;
        }
    }

    public interface IUserService
    {
        Task<User> GetUser(HttpContext HttpContext);
    }
}
