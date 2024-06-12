using Microsoft.AspNetCore.Mvc;

namespace CarRentCM.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult CarList()
        {
            return View();
        }
    }
}
