using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Threading.Tasks;
using Gymany.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Gymany.Controllers
{
    [Area("GymOwner")]
    public class GymOwnerController : Controller
    {
        private readonly HttpClient client = null;

        private string api;

        private string api_ProductByID;
        private string apiCategory;



        public GymOwnerController()
        {
            client = new HttpClient();
            var contentType = new MediaTypeWithQualityHeaderValue("application/json");
            client.DefaultRequestHeaders.Accept.Add(contentType);
            this.api = "https://localhost:5002/api/Product";
            this.api_ProductByID = "https://localhost:5002/api/Product/id";
            this.apiCategory = "https://localhost:5002/api/Category";
        }

        // page of admin after login successfull
        public IActionResult Home()
        {
            return View("Home", "GymManageLayout");
        }
        //page login for admin 
        public IActionResult Index()
        {
            return View("Index", "GymManageLayout");
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
        public async Task<IActionResult> UpdateProduct(int id)
        {
            api_ProductByID = $"https://localhost:5002/api/Product/id?id={id}";
            HttpResponseMessage response = await client.GetAsync(api_ProductByID);
            if (response.IsSuccessStatusCode)
            {
                var data = response.Content.ReadAsStringAsync().Result;
                var product = JsonSerializer.Deserialize<Product>(data);
                return View(product);
            }
            return NotFound();
        }
        [HttpPost]
        public async Task<IActionResult> UpdateProduct(int id, Product obj)
        {
            api_ProductByID = $"https://localhost:5002/api/Product/id?id={id}";
            obj.ProductID = id;
            string data = JsonSerializer.Serialize(obj);
            var content = new StringContent(data, System.Text.Encoding.UTF8, "application/json");
            HttpResponseMessage response = await client.PutAsync(api_ProductByID, content);
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("Product");
            }
            return Redirect("UpdateProduct");
        }


        public async Task<IActionResult> DeleteProduct(int id)
        {
            api_ProductByID = $"https://localhost:5002/api/Product/id?id={id}";
            HttpResponseMessage response = await client.GetAsync(api_ProductByID);
            if (response.IsSuccessStatusCode)
            {
                var data = response.Content.ReadAsStringAsync().Result;
                var product = JsonSerializer.Deserialize<Product>(data);
                return View(product);
            }
            return NotFound();
        }
        [HttpPost]
        public async Task<ActionResult> DeleteProduct(int id, Product obj)
        {
            api_ProductByID = $"https://localhost:5002/api/Product/id?id={id}";

            try
            {
                // Tạo yêu cầu DeleteProduct
                obj.ProductID = id;
                HttpResponseMessage response = await client.DeleteAsync(api_ProductByID);
                var data = response.Content.ReadAsStringAsync().Result;
                var product = JsonSerializer.Deserialize<Product>(data);
                // Kiểm tra kết quả trả về từ endpoint API
                if (response.IsSuccessStatusCode)
                {
                    // Xử lý kết quả nếu xóa thành công, ví dụ chuyển hướng đến trang danh sách
                    return RedirectToAction("Product");

                }
                else
                {
                    // Xử lý kết quả nếu xóa không thành công, ví dụ hiển thị thông báo lỗi
                    return View();
                }
            }
            catch (Exception ex)
            {
                // Xử lý lỗi nếu có
                return View("Error");
            }
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
        public IActionResult DeleteProductAccount()
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
        public IActionResult DeleteProductPost()
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