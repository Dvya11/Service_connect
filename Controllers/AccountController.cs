using Microsoft.AspNetCore.Mvc;

namespace Service_connect.Controllers
{
    public class AccountController : Controller
    {
        // LOGIN
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
                return RedirectToAction("Dashboard", "Home");
            }

            ViewBag.Error = "Invalid Email or Password";
            return View();
        }

        // REGISTER / SIGNUP
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
    }
}