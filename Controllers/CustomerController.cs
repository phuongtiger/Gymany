using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Gymany.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Login()
        {
            // TODO: Your code here
            return View();
        }

        public IActionResult Register()
        {
            // TODO: Your code here
            return View();
        }

        public IActionResult PTPage()
        {
            // Chuyển sang action khác trong cùng khu vực
            return Redirect(Url.Action("PTLogin", "PT", new { area = "PT" }));
        }
    }

}