using System.IO;
using System.Linq;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using Addons;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Newtonsoft.Json;
using ProxyChecker;
using WebCalculator.BL;
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

         readonly AdditionalConsoleLogger conLogger = new AdditionalConsoleLogger(_hubContext);
        
        public bool CheckProxy()
        {
            NotyMessage message = new NotyMessage(){Message="Run task: CheckProxy", Type="Info"};
            SendNotyToClient("Info", "Run task: CheckProxy");
           
            Task.Run(() => CheckProxyTask());
            return true;
        }

        private void SendNotyToClient(string type, string message)
        {          
            _hubContext.Clients.All.SendAsync("ShowNoty",type, message);
        }

        private WebProxy CheckProxyTask()
        {
            
            string proxyFilePath = Path.Combine(_env.WebRootPath, "proxyServers.txt"); 
            ProxyChecker.ProxyChecker checker = new ProxyChecker.ProxyChecker(conLogger, proxyFilePath);
            Proxy[] proxys = checker.Check(checker.ProxyList, "https://yobit.net/api/3/ticker/btc_usd");
            Proxy bestProxy = proxys.Where(s=>s.IsWork).OrderBy(s=>s.Ping).First();

            if (!bestProxy.IsWork)
            {
                throw new BadProxyException("Нет подходящего прокси сервера, нужно обновить список");
            }


            foreach (var prox in proxys)
            {
                conLogger.Log(prox.ToString() + "\t" + prox.IsWork + "\t" + prox.Ping + " ms");    
            }
            
            conLogger.Log("The best --> " + bestProxy.ToString() + "\t ping --> " + bestProxy.Ping);
                                            
            return new WebProxy(bestProxy.ToString());
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}