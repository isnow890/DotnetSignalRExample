using Microsoft.AspNetCore.SignalR;

namespace WebApiWithSIgnalRExample.SignalR
{
    public class ChatHub:Hub
    {
        public async Task SendMessage(string use, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", use, message);
        }
    }
}
