using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace WebCalculator.Models
{
     public class MessagesHub : Hub
    {
        public async Task ShowNoty(string type, string message)
        {
            await this.Clients.All.SendAsync("ShowNoty", type, message);
        }
        
        public async Task AddMessageToLog(string messageJson)
        {
            await this.Clients.All.SendAsync("AddMessageToLog", messageJson);
        }

        public async Task SendToConsole(string message)
        {
            await this.Clients.All.SendAsync("SendToConsole", message);
        }
    }
}