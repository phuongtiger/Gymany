using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Gymany.Models;
using Microsoft.AspNetCore.Http;
using X.PagedList;


namespace Gymany.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        public ProductController productController;
        public HomeController()
        {
            productController = new ProductController();
        }

        public IActionResult Index(int? page)
        {
            List<Product> products = productController.GetProduct().Result;
            List<Notification> notifications = HttpContext.Session.GetObjectFromJson<List<Notification>>("Notifications");
            string number = HttpContext.Session.GetString("NumberNoti");
            List<Category> categories = productController.GetCategory().Result;
            var listpage = products.ToPagedList(page ?? 1, 8);
            var viewModel = new ListModels
            {
                ListProducts = listpage,
                NumberNoti = number,
                Notifications = notifications,
                Categories = categories
            };
            return View(viewModel);
        }

        [HttpPost]
        public IActionResult Search(string SearchContent)
        {
            List<Product> products = productController.GetProduct().Result;
            if (!String.IsNullOrEmpty(SearchContent))
            {
                products = products.Where(s => s.Name.ToLower().Contains(SearchContent.ToLower())).ToList();
            }else{
                return RedirectToAction("Index");
            }
            ListModels listModels = new ListModels
            {
                Products = products,
                NumberNoti = HttpContext.Session.GetString("NumberNoti"),
                Notifications = HttpContext.Session.GetObjectFromJson<List<Notification>>("Notifications"),
                Categories = productController.GetCategory().Result
            };
            return View(listModels);
        }
        public IActionResult BMI()
        {
            ListModels listModels = new ListModels();
            return View(listModels);
        }
        
    }
}
