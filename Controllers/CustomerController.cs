using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Service_connect.Controllers
{
    public class CustomerController : Controller
    {
        // 🔹 Dashboard Page
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

        // 🔹 Profile Page
        public IActionResult Profile()
        {
            return View();
        }
    }

    // 🔹 Model Class
    public class ServiceRequest
    {
        public string? ProviderName { get; set; }
        public string? ServiceType { get; set; }
        public string? Date { get; set; }
        public string? Status { get; set; }
    }
}