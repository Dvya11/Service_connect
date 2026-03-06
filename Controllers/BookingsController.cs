using Microsoft.AspNetCore.Mvc;
using Service_connect.Models;

namespace Service_connect.Controllers
{
    public class BookingsController : Controller
    {
        public IActionResult MyBookings()
        {
            var bookings = new List<Booking>
            {
                new Booking
                {
                    CustomerName = "John Doe",
                    Service = "Electrician",
                    Status = "Pending",
                    Date = "Oct 24, 2023",
                    Time = "10:00 AM",
                    Image = "/images/user1.jpg"
                },

                new Booking
                {
                    CustomerName = "BuildIt Co.",
                    Service = "Carpenter",
                    Status = "Completed",
                    Date = "Oct 20, 2023",
                    Time = "02:00 PM",
                    Image = "/images/user2.jpg"
                },

                new Booking
                {
                    CustomerName = "Fix-It Fast",
                    Service = "Plumber",
                    Status = "Rejected",
                    Date = "Oct 18, 2023",
                    Time = "09:00 AM",
                    Image = "/images/user3.jpg"
                }
            };

            return View(bookings);
        }
    }
}