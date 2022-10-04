using Microsoft.AspNetCore.SignalR.Client;
using Messanger.BLL.Servicies.HubServicies;


namespace Messanger.BLL.Servicies.MessengerServices
{
    public class MessangerService
    {
         HubConnectionService hubConnection;
        public MessangerService(HubConnectionService hubConnection)
        {
            this.hubConnection = hubConnection;
        }
        public async Task InstanseOfOneUser()
        { 
        await 
        
        }
        
       
    }
}
