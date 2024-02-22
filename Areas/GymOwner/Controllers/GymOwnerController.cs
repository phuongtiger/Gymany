using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Gymany.Controllers
{
    [Area("GymOwner")]
    public class GymOwnerController : Controller
    {

        // page of admin after login successfull
        public IActionResult Home()
        {
            return View("Home", "GymOwnerLayout");
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
        public IActionResult Product()
        {
            // TODO: Your code here
            return View();
        }

        public IActionResult AddProduct()
        {
            // TODO: Your code here
            return View();
        }
        public IActionResult UpdateProduct()
        {
            // TODO: Your code here
            return View();
        }
        public IActionResult DeleteProduct()
        {
            // TODO: Your code here
            return View();
        }
        public IActionResult Account()
        {
            // TODO: Your code here
            return View();
        }
        public IActionResult AddAccount()
        {
            // TODO: Your code here
            return View();
        }
        public IActionResult DeleteAccount()
        {
            // TODO: Your code here
            return View();
        }
        public IActionResult Post()
        {
            // TODO: Your code here
            return View();
        }
        public IActionResult AddPost()
        {
            // TODO: Your code here
            return View();
        }
        public IActionResult DeletePost()
        {
            // TODO: Your code here
            return View();
        }
        public IActionResult Request()
        {
            // TODO: Your code here
            return View();
        }
        public IActionResult ManageRequest()
        {
            // TODO: Your code here
            return View();
        }


    }
}