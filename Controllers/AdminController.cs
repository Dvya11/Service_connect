using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace Service_connect.Controllers
{
    public class AdminController : Controller
    {
        // ===== ADMIN LOGIN =====

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string email, string password)
        {
            if (email == "admin@gmail.com" && password == "admin123")
            {
                TempData["Success"] = "Admin Login Successfully";
                return RedirectToAction("Dashboard", "Customer");
            }

            ViewBag.Error = "Invalid Admin Login";
            return View();
        }

        // ===== ADMIN DASHBOARD =====

        public IActionResult Dashboard()
        {
            return View();
        }

        // ===== ADMIN PROFILE =====

        public IActionResult Profile()
        {
            return View();
        }

        // ===== PROVIDER PROFILE =====

        public IActionResult ProviderProfile()
        {
            return View();
        }

        // ===== LOGOUT =====

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login", "Admin");
        }
    }
}