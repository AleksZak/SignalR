using Microsoft.AspNetCore.SignalR.Client;
using Messanger.BLL.DTO;

namespace Messanger.BLL.Servicies.HubServicies
{
    public class HubConnectionService
    {   
        static HubConnection _hubConnection;
        public static async Task InitSignalRConnection()
        {

           _hubConnection = new Microsoft.AspNetCore.SignalR.Client.HubConnectionBuilder().WithUrl("https://localhost:7099/notification").Build();
            _hubConnection.On<string>("Send", message =>
            {
                Console.WriteLine(message);

            });


            await _hubConnection.StartAsync();
        }

        public async Task DoInstanseOfOneUserMessage(string input, UserDTO userDTO)
        {
            await InitSignalRConnection();

            while (true)
            {
                var message = new MessageDTO
                {
                    Title = userDTO.UserName,
                    Text = input

                };
                await _hubConnection.SendAsync("SendMessage",message);
            }


        }

    }



}
