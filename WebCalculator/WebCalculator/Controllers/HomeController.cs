using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using WebCalculator.Models;

namespace WebCalculator.Controllers
{
    public class HomeController : Controller
    {

        private static  IHubContext<MessagesHub> _hubContext;
        private IHostingEnvironment _env;

         public HomeController(IHostingEnvironment env, IHubContext<MessagesHub> hubContext)
        {
            _env = env;
            _hubContext = hubContext;

        }
        public IActionResult Index()
        {
            return View();
        }
         

         public IActionResult Dashboard_2()
         {
             return View();
         }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
