using Microsoft.AspNetCore.Mvc;

namespace ServiceConnect.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}