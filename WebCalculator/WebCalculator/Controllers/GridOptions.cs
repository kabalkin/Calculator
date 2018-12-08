using Microsoft.AspNetCore.Mvc;

namespace WebCalculator.Controllers{
       public class GridOptionsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}