using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authentication;
using System.Threading.Tasks;
using Service_center.Models;

namespace Service_center.Controllers
{
    public class AccountController : Controller
    {

        //  LOGIN PAGE LOAD 
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        //  LOGIN BUTTON CLICK 
        [HttpPost]
        public IActionResult Login(string email, string password)
        {
            if (email == "dchauhan664@rku.ac.in" && password == "123456")
            {
                TempData["Success"] = "Successfully Login";

                // Same login page par hi rehna
                return View();
            }

            ViewBag.Error = "Invalid Email or Password";
            return View();
        }

        //  REGISTER PAGE LOAD 
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        //  REGISTER BUTTON CLICK 
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
            // Future: Database save logic

            TempData["Success"] = "Registration Successful";
            return RedirectToAction("Login");
        }

        // CHANGE PASSWORD PAGE LOAD 
        [HttpGet]
        public IActionResult ChangePassword()
        {
            return View();
        }

        // CHANGE PASSWORD BUTTON CLICK 
        [HttpPost]
        public IActionResult ChangePassword(ChangePasswordViewModel model)
        {
            // Direct redirect for testing
            return RedirectToAction("Settings", "Customer");
        }

        //  LOGOUT 
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            HttpContext.Session.Clear();

            return RedirectToAction("Login");
        }
    }
}