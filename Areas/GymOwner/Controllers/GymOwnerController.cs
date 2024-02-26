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
using Gymany_API.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
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

        private string api_GymOwner;



        public GymOwnerController()
        {
            client = new HttpClient();
            var contentType = new MediaTypeWithQualityHeaderValue("application/json");
            client.DefaultRequestHeaders.Accept.Add(contentType);
            this.api = "https://localhost:5002/api/Product";
            this.api_ProductByID = "https://localhost:5002/api/Product/id";
            this.apiCategory = "https://localhost:5002/api/Category";
            this.api_GymOwner = "https://localhost:5002/api/GymOwner/checklogin";


        }

        // page of admin after login successfull
        public IActionResult Home()
        {
            if (!checkLogin())
            {
                return Redirect("/GymOwner/Index");
            }
            return View("Home", "GymManageLayout");
        }


        //page login for admin 


        public IActionResult Index()
        {
            return View(new GymOwner());
        }
        [HttpPost]
        public async Task<IActionResult> Login(string username, string password)
        {
            api_GymOwner = $"https://localhost:5002/api/GymOwner/checklogin?username={username}&password={password}";
            var gymOwner = new GymOwner { Username = username, Password = password };
            var content = new StringContent(JsonSerializer.Serialize(gymOwner), Encoding.UTF8, "application/json");
            HttpResponseMessage response = await client.PostAsync(api_GymOwner, content);
            Console.WriteLine(gymOwner);
            if (response.IsSuccessStatusCode)
            {
                System.Console.WriteLine("1");
                // var user = await response.Content.ReadFromJsonAsync<GymOwner>();
                // Lưu thông tin người dùng vào session hoặc cookie
                HttpContext.Session.SetString("Username", username);
                HttpContext.Session.SetString("Password", password);
                // Chuyển hướng đến trang chủ
                return RedirectToAction("Home", "GymOwner");
            }
            else
            {
                System.Console.WriteLine("2");
                Console.WriteLine($"Error: {response.StatusCode}");
                // Hiển thị thông báo lỗi
                ViewData["Error"] = "Invalid username or password";
                return View("Index", gymOwner);
            }
        }

        //method being call after submit the login form



        public async Task<IActionResult> Product()
        {
            if (!checkLogin())
            {
                return Redirect("/GymOwner/Index");
            }
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
            ViewBag.CategoryID = await GetSelectItem();
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
            if (!checkLogin())
            {
                return Redirect("/GymOwner/Index");
            }
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
            if (!checkLogin())
            {
                return Redirect("/GymOwner/Index");
            }
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
            if (!checkLogin())
            {
                return Redirect("/GymOwner/Index");
            }
            return View();
        }

        public async Task<List<SelectListItem>> GetSelectItem()
        {
            HttpResponseMessage respone = await client.GetAsync(apiCategory);
            string data = await respone.Content.ReadAsStringAsync();
            var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            List<Category> list = JsonSerializer.Deserialize<List<Category>>(data, options);
            List<SelectListItem> yourData = list.Select(c => new SelectListItem
            {
                Value = c.CategoryID.ToString(), // ID của category là giá trị của mục
                Text = c.Type // Tên của category là nội dung của mục
            }).ToList();
            return yourData;
        }


        //method check session
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