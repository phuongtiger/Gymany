using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Net.Http;
using System.Net.Http.Headers;
using Gymany.Models;

namespace Gymany.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Login()
        {
            // TODO: Your code here
            return View();
        }

        public IActionResult PTLogin()
        {
            // TODO: Your code here
            return View();
        }

        public IActionResult Register()
        {
            // TODO: Your code here
            return View();
        }

        public IActionResult PTRegister()
        {
            // TODO: Your code here
            return View();
        }



    }

}