using System;
using Addons;
using Microsoft.AspNetCore.SignalR;
using Newtonsoft.Json;
using WebCalculator.Models;

namespace WebCalculator.BL
{
   public class AdditionalConsoleLogger:ILogger
    {
        private IHubContext<MessagesHub> _hubContext;
        
        public AdditionalConsoleLogger(IHubContext<MessagesHub>  hubContext)
        {
            _hubContext = hubContext;
        }


        public void Log(string message, string type="Info")
        {           
            LoggerMessage mes = new LoggerMessage();
            mes.Message = message;
            mes.Type = type;
            mes.Date = DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss");

            string jsonResult = JsonConvert.SerializeObject(mes);

            _hubContext.Clients.All.SendAsync("AddMessageToLog", jsonResult);
        }
    }
}