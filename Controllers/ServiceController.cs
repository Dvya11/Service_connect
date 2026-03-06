using Microsoft.AspNetCore.Mvc;
using Service_connect.Models;
using System.Collections.Generic;
using System.Linq;

namespace Service_connect.Controllers
{
    public class ServiceController : Controller
    {
        // 🔹 Services List Page
        public IActionResult Service()
        {
            return View();
        }

        // 🔹 Experts Page
        public IActionResult Index(string category)
        {
            List<ServiceExpert> experts = GetExperts();

            if (!string.IsNullOrEmpty(category))
            {
                experts = experts
                    .Where(x => x.Category.ToLower() == category.ToLower())
                    .ToList();

                ViewBag.SelectedCategory = category;
            }
            else
            {
                ViewBag.SelectedCategory = "All";
            }

            return View(experts);
        }

        // 🔹 Details Page
        public IActionResult Details(int id)
        {
            var expert = GetExperts().FirstOrDefault(x => x.Id == id);

            if (expert == null)
                return NotFound();

            return View(expert);
        }

        // 🔹 BOOK SERVICE PAGE (GET)
        [HttpGet]
        public IActionResult BookService(string expertName)
        {
            ViewBag.ExpertName = expertName;
            return View();
        }

        // 🔹 BOOK SERVICE FORM SUBMIT (POST)
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult BookService(BookServiceViewModel model)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Success");
            }

            return View(model);
        }

        // 🔹 SUCCESS PAGE (Views/Request/Success.cshtml)
        public IActionResult Success()
        {
            return View("~/Views/Request/Success.cshtml");
        }

        // 🔹 LOGOUT METHOD
        [HttpGet]
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();   // session clear karega
            return View(); // Logout.cshtml open karega
        }

        // 🔹 Common Expert List Method
        private List<ServiceExpert> GetExperts()
        {
            return new List<ServiceExpert>
            {
                new ServiceExpert {
                    Id = 1,
                    Name = "Rahul",
                    Category = "Plumber",
                    Location = "Mumbai",
                    Distance = 2,
                    Rating = 4.5,
                    Description = "Pipe repair expert",
                    ImageUrl = "https://randomuser.me/api/portraits/men/1.jpg"
                },
                new ServiceExpert {
                    Id = 2,
                    Name = "Amit",
                    Category = "Electrician",
                    Location = "Delhi",
                    Distance = 3,
                    Rating = 4.8,
                    Description = "Wiring specialist",
                    ImageUrl = "https://randomuser.me/api/portraits/men/2.jpg"
                },
                new ServiceExpert {
                    Id = 3,
                    Name = "Suresh",
                    Category = "Carpenter",
                    Location = "Ahmedabad",
                    Distance = 4,
                    Rating = 4.6,
                    Description = "Furniture repair expert",
                    ImageUrl = "https://randomuser.me/api/portraits/men/3.jpg"
                }
            };
        }
    }
}