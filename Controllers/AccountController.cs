using Microsoft.AspNetCore.Mvc;

namespace Service_connect.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string email, string password)
        {
            if (email == "admin@company.com" && password == "123456")
            {
                return RedirectToAction("Service", "Services");
            }

            ViewBag.Error = "Invalid Email or Password";
            return View();
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(
            string userType,
            string firstName,
            string lastName,
            string email,
            string category,
            string experience,
            string password)
        {
            return RedirectToAction("Service", "Service");
        }
    }
}