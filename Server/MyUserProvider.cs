using Microsoft.AspNetCore.SignalR;

namespace Server
{
    public class MyUserProvider : IUserIdProvider
    {
        public string GetUserId(HubConnectionContext connection)
        {
            var httpContext = connection.GetHttpContext();

            if (httpContext.Request.Query.ContainsKey("name"))
                return httpContext.Request.Query["name"].First();

            return "Anonymous";
        }
    }
}
