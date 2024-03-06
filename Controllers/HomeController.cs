using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Gymany.Models;
using Microsoft.AspNetCore.Http;


namespace Gymany.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ProductController productController = new ProductController();
            List<Product> products = productController.GetProduct().Result;
            List<Notification> notifications = HttpContext.Session.GetObjectFromJson<List<Notification>>("Notifications");
            string number = HttpContext.Session.GetString("NumberNoti");
            var viewModel = new ListModels
            {
                Products = products,
                NumberNoti = number,
                Notifications = notifications
            };
            return View(viewModel);
        }
    }
}
