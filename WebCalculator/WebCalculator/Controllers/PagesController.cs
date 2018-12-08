using Microsoft.AspNetCore.Mvc;

namespace WebCalculator.Controllers
{
      public class PagesController : Controller
    {


        public IActionResult LockScreen()
        {
            return View();
        }


        public IActionResult Login()
        {
            return View();
        }

  
    }
}