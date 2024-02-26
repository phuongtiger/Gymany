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
    public class CustomerController : Controller
    {
        public IActionResult Login()
        {
            // TODO: Your code here
            List<Notification> notifications = HttpContext.Session.GetObjectFromJson<List<Notification>>("Notifications");
            var viewModel = new ListModels
            {
                Notifications = notifications
            };
            return View(viewModel);
        }

        public IActionResult PTLogin()
        {
            // TODO: Your code here
            List<Notification> notifications = HttpContext.Session.GetObjectFromJson<List<Notification>>("Notifications");
            var viewModel = new ListModels
            {
                Notifications = notifications
            };
            return View(viewModel);
        }

        public IActionResult Register()
        {
            // TODO: Your code here
            List<Notification> notifications = HttpContext.Session.GetObjectFromJson<List<Notification>>("Notifications");
            var viewModel = new ListModels
            {
                Notifications = notifications
            };
            return View(viewModel);
        }

        public IActionResult PTPage()
        {
            // TODO: Your code here
            // List<Notification> notifications = HttpContext.Session.GetObjectFromJson<List<Notification>>("Notifications");
            // var viewModel = new ListModels
            // {
            //     Notifications = notifications
            // };
            // return View(viewModel);
            // Chuyển sang action khác trong cùng khu vực
            return Redirect(Url.Action("PTLogin", "PT", new { area = "PT" }));
        }
    }

}