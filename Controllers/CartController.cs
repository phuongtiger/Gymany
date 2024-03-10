using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Threading.Tasks;
using Gymany.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Gymany.Controllers
{
    public class CartController : Controller
    {

        private readonly HttpClient client = null;
        private string api_CartById;
        private string api;

        public CartController()
        {
            client = new HttpClient();
            var contentType = new MediaTypeWithQualityHeaderValue("application/json");
            client.DefaultRequestHeaders.Accept.Add(contentType);
            this.api_CartById = $"https://localhost:5002/api/Cart/CustomerID";
            this.api = $"https://localhost:5002/api/Cart";
        }



        public async Task<List<Cart>> GetCart()
        {
            string id = HttpContext.Session.GetString("CustomerID");
            api_CartById = $"https://localhost:5002/api/Cart/CustomerID?CustomerID={id}";
            HttpResponseMessage respone = await client.GetAsync(api_CartById);
            string data = await respone.Content.ReadAsStringAsync();

            if (string.IsNullOrEmpty(data))
            {
                // Thông báo khi dữ liệu không có
                Console.WriteLine("Không có dữ liệu trong giỏ hàng.");
                return new List<Cart>();
            }

            var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            List<Cart> carts = JsonSerializer.Deserialize<List<Cart>>(data, options);

            if (carts == null)
            {
                // Thông báo khi danh sách carts là null
                Console.WriteLine("Danh sách giỏ hàng trống.");
                return new List<Cart>();
            }

            return carts;
        }



        public async Task<ActionResult> Index()
        {
            if (!checkLogin())
            {
                return RedirectToAction("Form", "Customer");
            }
            List<Cart> carts = await GetCart();
            var viewModel = new ListModels
            {
                Carts = carts
            };
            return View(viewModel);
        }



        public async Task<ActionResult> Create()
        {
            if (!checkLogin())
            {
                return Redirect("Create/Form");
            }
            return View();
        }

       [HttpPost] 
        public async Task<ActionResult> Create(Cart obj)
        {
            if (!checkLogin())
            {
                return Redirect("Cart/Form");
            }
            if (ModelState.IsValid)
            {
               string data = JsonSerializer.Serialize(obj); 
               var content = new StringContent(data, System.Text.Encoding.UTF8, "application/json");
               HttpResponseMessage respone = await client.PostAsync(api, content);
               if (respone.StatusCode == System.Net.HttpStatusCode.Created)
               {
                return RedirectToAction("Index");
               }
            }
            return View(obj);
        }







        [HttpPost]
        public bool checkLogin()
        {
            var username = HttpContext.Session.GetString("Username");
            var pass = HttpContext.Session.GetString("Password");
            if (username != null && pass != null)
            {
                return true;
            }
            return false;
        }
    }
}