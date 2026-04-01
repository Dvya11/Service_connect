using Microsoft.AspNetCore.Mvc;
using Service_connect.Models;
using System;
using System.Collections.Generic;

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
                    CustomerName = "Krish",
                    Service = "Electrician",
                    Status = "Pending",
                    Date = new DateTime(2023, 10, 24),
                    Time = "10:00 AM",
                    Image = "/images/user1.jpg"
                },

                new Booking
                {
                    CustomerName = "Vishnu",
                    Service = "Carpenter",
                    Status = "Completed",
                    Date = new DateTime(2023, 10, 20),
                    Time = "02:00 PM",
                    Image = "/images/user2.jpg"
                },

                new Booking
                {
                    CustomerName = "Rahul",
                    Service = "Plumber",
                    Status = "Rejected",
                    Date = new DateTime(2023, 10, 18),
                    Time = "09:00 AM",
                    Image = "/images/user3.jpg"
                }
            };

            return View(bookings);
        }
    }
}