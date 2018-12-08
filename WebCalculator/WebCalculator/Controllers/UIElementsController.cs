using Microsoft.AspNetCore.Mvc;

namespace WebCalculator.Controllers
{
    public class UIElementsController : Controller
    {       
        public IActionResult Icons()
        {
            return View();
        }              

        public IActionResult Buttons()
        {
            return View();
        }       
       
        public IActionResult Tabs()
        {
            return View();
        }               

        public IActionResult HelperClasses()
        {
            return View();
        }
    }
}