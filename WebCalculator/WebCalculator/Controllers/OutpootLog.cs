using System.Threading.Tasks;
using Addons;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Newtonsoft.Json;
using WebCalculator.Models;

namespace WebCalculator.Controllers
{
    public class OutpootLog : Controller
    {

        private static IHubContext<MessagesHub> _hubContext;
        private IHostingEnvironment _env;

        public OutpootLog(IHostingEnvironment env, IHubContext<MessagesHub> hubContext)
        {
            _env = env;
            _hubContext = hubContext;

        }
        
        public bool CheckProxy()
        {
            NotyMessage message = new NotyMessage(){Message="Run task: CheckProxy", Type="Info"};
            SendNotyToClient(message);
            Task.Run(() => CheckProxyTask());
            return true;
        }

        private void SendNotyToClient(NotyMessage message)
        {
            string jsonMessage = JsonConvert.SerializeObject(message);
            _hubContext.Clients.All.SendAsync("ShowNoty", message);
        }

        private void CheckProxyTask()
        {

        }

        public IActionResult Index()
        {
            return View();
        }
    }
}