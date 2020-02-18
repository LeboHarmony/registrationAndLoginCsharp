using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Csharp_Seat_Booking_System.Models;
using Microsoft.AspNetCore.Mvc;

namespace Csharp_Seat_Booking_System.Controllers
{
    public class UserRegistrationController : Controller
    {
        private readonly ApplicationUserClass _auc;

        public UserRegistrationController(ApplicationUserClass auc)
        {
            _auc = auc;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(UserClass uc)
        {
            _auc.Add(uc);
            _auc.SaveChanges();
            ViewBag.message = "The User " + uc.Username + " Is Saved Successfully";
            return View();
        }
    }
}