using Microsoft.AspNetCore.SignalR;

namespace Chat_Function.Hubs;

public class ChatHub : Hub
{
    public async Task SendMessage (string user,string message) 
    {
        Clients.All.SendAsync("RecieveMessage", user, message);
    }
}
