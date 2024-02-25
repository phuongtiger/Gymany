using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Threading.Tasks;
using Gymany.Models;
using Gymany_API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Gymany.Controllers
{
    [Area("GymOwner")]
    public class GymOwnerController : Controller
    {
        private readonly HttpClient client = null;
        private string api;
        public GymOwnerController()
        {
            client = new HttpClient();
            var contentType = new MediaTypeWithQualityHeaderValue("application/json");
            client.DefaultRequestHeaders.Accept.Add(contentType);
            this.api = "https://localhost:5002/api/Product";
        }

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
        // Product Manage
         public async Task<IActionResult> Product()
        {
            HttpResponseMessage response = await client.GetAsync(api);
            string data = await response.Content.ReadAsStringAsync();
            var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            List<Product> list = JsonSerializer.Deserialize<List<Product>>(data, options);
            return View(list);

        }

        public IActionResult AddProduct()
        {
            // TODO: Your code here
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddProduct(Product obj)
        {
            if (ModelState.IsValid)
            {
                string data = JsonSerializer.Serialize(obj);
                var content = new StringContent(data, System.Text.Encoding.UTF8, "application/json");
                HttpResponseMessage response = await client.PostAsync(api, content);
                if (response.StatusCode == System.Net.HttpStatusCode.Created)
                    return RedirectToAction("Product");
            }
            return View(obj);
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