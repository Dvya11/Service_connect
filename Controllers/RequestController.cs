using Microsoft.AspNetCore.Mvc;
using Service_connect.Models;

namespace Service_connect.Controllers
{
    public class RequestController : Controller
    {
        // GET: Book Service page
        public IActionResult BookService(string expertName)
        {
            ViewBag.ExpertName = expertName;
            return View();
        }

        // ✅ POST: Form submit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult BookService(BookServiceViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            // 👉 Yahan DB save logic aayega (future)

            // ✅ SUCCESS PAGE PAR REDIRECT
            return RedirectToAction("Success");
        }

        // ✅ SUCCESS PAGE
        public IActionResult Success()
        {
            return View();
        }
    }
}