using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace WebCalculator.Models
{
     public class MessagesHub : Hub
    {
        public async Task ShowNoty(string message)
        {
            await this.Clients.All.SendAsync("ShowNoty", message);
        }
        
        public async Task SendData(string message)
        {
            await this.Clients.All.SendAsync("SendData", message);
        }

        public async Task SendToConsole(string message)
        {
            await this.Clients.All.SendAsync("SendToConsole", message);
        }
    }
}