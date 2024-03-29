﻿using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace Server.HUB
{
    public class MessageHub : Hub<IMessageClient>
    {
        public Task SendToOthers(Message message)
        {
            var messageForClient = NewMessage.Create(Context.UserIdentifier, message);
            return Clients.Others.Send(messageForClient);
        }

        public Task Subscribe()
        {
            return Groups.AddToGroupAsync(Context.ConnectionId, "Subscribers");
        }

        public Task Unsubscribe()
        {
            return Groups.RemoveFromGroupAsync(Context.ConnectionId, "Subscribers");
        }

    }
}
