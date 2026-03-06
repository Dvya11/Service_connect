using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authentication;
using System.Threading.Tasks;

namespace Service_connect.Controllers
{
    public class AccountController : Controller
    {
        // ================= LOGIN =================

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
                return RedirectToAction("Dashboard", "Customer");
            }

            ViewBag.Error = "Invalid Email or Password";
            return View();
        }

        // ================= REGISTER =================

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
            // (Here you can save user to database later)

            // After register redirect to Service page
            return RedirectToAction("Service", "Service");
        }

        // ================= LOGOUT =================

        public async Task<IActionResult> Logout()
        {
            // Clear Authentication Cookie (if using cookie auth)
            await HttpContext.SignOutAsync();

            // Clear Session
            HttpContext.Session.Clear();

            return View(); // Views/Account/Logout.cshtml
        }
    }
}