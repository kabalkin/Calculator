using Microsoft.AspNetCore.Mvc;

namespace WebCalculator.Controllers
{
    public class MetricsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}