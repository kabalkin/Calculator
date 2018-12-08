using Microsoft.AspNetCore.Mvc;

namespace WebCalculator.Controllers
{
     public class MiscellaneousController : Controller
    {
        public IActionResult ModalWindow()
        {
            return View();
        }

        public IActionResult NestableList()
        {
            return View();
        }

        public IActionResult Validation()
        {
            return View();
        }

        public IActionResult Notification()
        {
            return View();
        }

        public IActionResult IdleTimer()
        {
            return View();
        }

        public IActionResult Spinners()
        {
            return View();
        }

        public IActionResult SpinnersUsage()
        {
            return View();
        }

        public IActionResult LoadingButtons()
        {
            return View();
        }
    }
}