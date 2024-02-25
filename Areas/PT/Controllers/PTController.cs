using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Threading.Tasks;
using Gymany.Models;
using Microsoft.AspNetCore.Mvc;

namespace Gymany.Controllers
{
    [Area("PT")]
    public class PTController : Controller
    {
        private readonly HttpClient client = null;
        private string api;
        private string api2;
        public PTController()
        {
            client = new HttpClient();
            var contentType = new MediaTypeWithQualityHeaderValue("application/json");
            client.DefaultRequestHeaders.Accept.Add(contentType);
            this.api = "https://localhost:5002/api/Member";
            this.api2 = "https://localhost:5002/api/Customer";
        }
        public async Task<IActionResult> Index()
        {
            HttpResponseMessage response = await client.GetAsync(api);
            string data = await response.Content.ReadAsStringAsync();
            var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            List<Member> list = JsonSerializer.Deserialize<List<Member>>(data, options);
            return View(list);
        }

        public async Task<ActionResult> MemberDetail()
        {
            HttpResponseMessage response = await client.GetAsync(api2);
            string data = await response.Content.ReadAsStringAsync();
            var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            List<Customer> list = JsonSerializer.Deserialize<List<Customer>>(data, options);
            return View(list);
        }

        public IActionResult BackToLogin()
        {
            // TODO: Your code here
            return Redirect(Url.Action("Login", "Customer"));
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

        public IActionResult ActionName()
        {
            // TODO: Your code here
            return View();
        }

    }
}