using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Gymany.Controllers
{
    [Area("PT")]
    public class PTController : Controller
    {
        public IActionResult Index()
        {
            // TODO: Your code here
            return View("Index");
        }

        public IActionResult PTRegister()
        {
            // TODO: Your code here
            return View();
        }

        public IActionResult PTLogin()
        {
            // TODO: Your code here
            return View();
        }
    }
}