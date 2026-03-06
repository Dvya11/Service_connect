using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace ServiceConnect.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Dashboard()
        {
            return View();
        }

        public IActionResult Profile()
        {
            return View();
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Dashboard", "Admin");
        }
    }
}