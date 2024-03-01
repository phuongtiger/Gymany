using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Gymany.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Gymany.Controllers
{
    public class BlogController : Controller
    {
        
        public IActionResult Index(){
            List<Notification> notifications = HttpContext.Session.GetObjectFromJson<List<Notification>>("Notifications");
            var viewModel = new ListModels
            {
                Notifications = notifications
            };
            return View(viewModel);
        }


        public IActionResult blogdetail(){
            List<Notification> notifications = HttpContext.Session.GetObjectFromJson<List<Notification>>("Notifications");
            var viewModel = new ListModels
            {
                Notifications = notifications
            };
            return View(viewModel);
        }
    }
}