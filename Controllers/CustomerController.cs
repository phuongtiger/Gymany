using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Security.Claims;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Gymany.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
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



        private readonly HttpClient client = null;

        private string api;

        private string api_Customer;


         public CustomerController()
        {
            client = new HttpClient();
            var contentType = new MediaTypeWithQualityHeaderValue("application/json");
            client.DefaultRequestHeaders.Accept.Add(contentType);
            this.api = "https://localhost:5002/api/Customer";
            // this.api_ProductByID = "https://localhost:5002/api/Product/id";
            // this.apiCategory = "https://localhost:5002/api/Category";
            this.api_Customer = "https://localhost:5002/api/Customer/checklogin";
        }
        

        // page of admin after login successfull
        public IActionResult Home()
        {
            if (!checkLogin())
            {
                return Redirect("/Customer/Index");
            }
            return View("Home", "CustomerLayout");
        }


        //page login for admin 
        public IActionResult Index()
        {
            return View(new Customer());
        }
        [HttpPost]
        public async Task<IActionResult> Login(string username, string password)
        {
            api_Customer = $"https://localhost:5002/api/Customer/checklogin?username={username}&password={password}";
            var Customer = new Customer { Username = username, Password = password };
            var content = new StringContent(JsonSerializer.Serialize(Customer), Encoding.UTF8, "application/json");
            HttpResponseMessage response = await client.PostAsync(api_Customer, content);
            Console.WriteLine(Customer);
            if (response.IsSuccessStatusCode)
            {
                System.Console.WriteLine("1");
                // var user = await response.Content.ReadFromJsonAsync<GymOwner>();
                // Lưu thông tin người dùng vào session hoặc cookie
                HttpContext.Session.SetString("Username", username);
                HttpContext.Session.SetString("Password", password);
                // Chuyển hướng đến trang chủ
                return RedirectToAction("Home", "Customer");
            }
            else
            {
                System.Console.WriteLine("2");
                Console.WriteLine($"Error: {response.StatusCode}");
                // Hiển thị thông báo lỗi
                ViewData["Error"] = "Invalid username or password";
                return View("Index", Customer);
            }
        }


        public bool checkLogin()
        {
            var email = HttpContext.Session.GetString("Username");
            var pass = HttpContext.Session.GetString("Password");
            if (email != null && pass != null)
            {
                return true;
            }
            return false;
        }

    }

}