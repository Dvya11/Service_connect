using Microsoft.AspNetCore.Mvc;
using Service_connect.Models;
using System.Collections.Generic;
using System.Linq;

namespace Service_connect.Controllers
{
    public class ProviderController : Controller
    {

        static List<VisitRequest> requests = new List<VisitRequest>()
        {
            new VisitRequest
            {
                Id = 1,
                CustomerName = "Sarah Jenkins",
                Address = "42 Oak Street, Garden City",
                Description = "Leaking kitchen faucet needs urgent repair.",
                Status = "Pending"
            },
            new VisitRequest
            {
                Id = 2,
                CustomerName = "Marcus Thorne",
                Address = "112 Maple Avenue, Westside",
                Description = "Main outdoor pipe burst.",
                Status = "Pending"
            }
        };

        public IActionResult Dashboard()
        {
            ViewBag.Name = "Marcus Miller";
            ViewBag.Profession = "Master Electrician";
            ViewBag.Rating = "4.92";
            ViewBag.Hours = "142h";

            return View();
        }

        public IActionResult VisitRequests()
        {
            return View(requests);
        }

        public IActionResult Accept(int id)
        {
            var req = requests.FirstOrDefault(x => x.Id == id);

            if (req != null)
                req.Status = "Accepted";

            return RedirectToAction("VisitRequests");
        }

        public IActionResult Reject(int id)
        {
            var req = requests.FirstOrDefault(x => x.Id == id);

            if (req != null)
                req.Status = "Rejected";

            return RedirectToAction("VisitRequests");
        }

    }
}