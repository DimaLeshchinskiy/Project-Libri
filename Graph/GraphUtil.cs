using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text.Json;
using System.Threading.Tasks;

namespace ProjectLibri.Graph
{
    public class GraphUtil : IGraphUtil
    {
        private readonly IGraphServiceClientFactory _graphServiceClientFactory;

        public GraphUtil(IGraphServiceClientFactory graphServiceClientFactory)
        {
            _graphServiceClientFactory = graphServiceClientFactory;
        }

        public async Task<GraphUser> GetUser(ClaimsPrincipal user, HttpContext HttpContext)
        {

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

            GraphUser graphUser = JsonSerializer.Deserialize<GraphUser>(json, options);

            return graphUser;
        }
    }

    public interface IGraphUtil
    {
        Task<GraphUser> GetUser(ClaimsPrincipal user, HttpContext HttpContext);
    }
}
