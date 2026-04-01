using Microsoft.AspNetCore.Mvc;
using Service_connect.Models;
using System.Collections.Generic;

namespace Service_connect.Controllers
{
    public class CustomerController : Controller
    {

        // ========= DASHBOARD ==========
        public IActionResult Dashboard()
        {
            ViewBag.UserName = "Alex Thompson";
            ViewBag.Pending = 2;
            ViewBag.Accepted = 5;
            ViewBag.Completed = 24;

            var requests = new List<ServiceRequest>
            {
                new ServiceRequest
                {
                    ProviderName = "John's Elite Plumbing",
                    ServiceType = "Pipe Repair",
                    Date = "Oct 12, 2023",
                    Status = "Accepted"
                },
                new ServiceRequest
                {
                    ProviderName = "Sparkle Home Care",
                    ServiceType = "Deep Cleaning",
                    Date = "Oct 15, 2023",
                    Status = "Pending"
                }
            };

            return View(requests);
        }


        // ================= PROFILE =================
        public IActionResult Profile()
        {
            return View("~/Views/Admin/Profile.cshtml");
        }


        // ================= SETTINGS PAGE =================
        public IActionResult Settings()
        {
            return View();
        }


        // ================= SETTINGS SAVE =================
        [HttpPost]
        public IActionResult Settings(AccountSettings model)
        {
            if (ModelState.IsValid)
            {
                // Future: database save logic
                return RedirectToAction("Dashboard", "Provider");
            }

            return View(model);
        }


        // ================= DELETE ACCOUNT PAGE =================
        public IActionResult DeleteAccount()
        {
            // Just returns the confirmation view
            return View();
        }


        // ================= DELETE ACCOUNT CONFIRM =================
        [HttpPost]
        public IActionResult DeleteAccountConfirm()
        {
            TempData["Message"] = "Your account has been deleted.";

            return RedirectToAction("Login", "Account");
        }

    }


    // ================= SERVICE REQUEST MODEL =================
    public class ServiceRequest
    {
        public string? ProviderName { get; set; }
        public string? ServiceType { get; set; }
        public string? Date { get; set; }
        public string? Status { get; set; }
    }
}