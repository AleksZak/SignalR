using Microsoft.AspNetCore.SignalR;

using Server.HUB;

namespace Server.Worker
{
    public class NoticeWorker : BackgroundService
    {
        private readonly IHubContext<MessageHub, IMessageClient> hubContext;
        private readonly Message messageForAnonymous;
        private readonly Message messageForSubscribers;

        public NoticeWorker(IHubContext<MessageHub, IMessageClient> hubContext)
        {
            this.hubContext = hubContext;
            messageForAnonymous = new Message { Text = "Please set your name" };
            messageForSubscribers = new Message { Text = "Hello subscriber" };
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                var newMessageForAnonymous = NewMessage.Create("System", messageForAnonymous);
                await hubContext.Clients.User("Anonymous").Send(newMessageForAnonymous);

                var newMessageForSubscribers = NewMessage.Create("System", messageForSubscribers);
                await hubContext.Clients.Group("Subscribers").Send(newMessageForSubscribers);

                await Task.Delay(TimeSpan.FromSeconds(5), stoppingToken);
            }
        }
    }
}
