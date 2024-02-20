using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Gymany.Controllers
{
   
    public class GymOwnerController : Controller
    {



        // page of admin after login successfull
          public IActionResult Home()
        {
            return View("Home","GymOwnerLayout");
        }
        //page login for admin 
          public IActionResult Index()
        {
            return View("Index", "GymOwnerLayout");
        }
        //method being call after submit the login form
        [HttpPost]
        public IActionResult Login(string username, string password)
        {
           

            if (string.Equals(username, "admin") && string.Equals(password, "pass"))
            {
                // username and password is correct, redirect to Page home
                return RedirectToAction("Home");
            }
            else
            {
                // username and password is incorrect, redirect back to login
                return View("Index");
            }
        }


    }
}