using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.Extensions.Logging;

using Gymany.Models;
using Microsoft.AspNetCore.Http;


namespace Gymany.Controllers
{
    public class ProductController : Controller
    {
        private readonly HttpClient client = null;
        private string api;
        private string api_ProductByID;
        private string apiCategory;
        public ProductController()
        {
            client = new HttpClient();
            var contentType = new MediaTypeWithQualityHeaderValue("application/json");
            client.DefaultRequestHeaders.Accept.Add(contentType);
            this.api = "https://localhost:5002/api/Product";
            this.apiCategory = "https://localhost:5002/api/Category";
            this.api_ProductByID = "https://localhost:5002/api/Product/id";
            
        }
        public async Task<List<Product>> GetProduct(){
            HttpResponseMessage respone = await client.GetAsync(api);
            string data = await respone.Content.ReadAsStringAsync();
            var options = new JsonSerializerOptions{PropertyNameCaseInsensitive = true};
            List<Product> products = JsonSerializer.Deserialize<List<Product>>(data, options);
            return products;
        }
        public async Task<ActionResult> Index()
        {

            List<Product> products = await GetProduct();
            List<Notification> notifications = HttpContext.Session.GetObjectFromJson<List<Notification>>("Notifications");
            string number = HttpContext.Session.GetString("NumberNoti");
            List<Category> categories = await GetCategory();
            var viewModel = new ListModels
            {
                Products = products,
                Notifications = notifications,
                NumberNoti = number,
                Categories = categories
            };
            return View(viewModel);
        }
        public async Task<ActionResult> Details(int? id)
        {
            api_ProductByID = $"https://localhost:5002/api/Product/id?id={id}";
            HttpResponseMessage respone = await client.GetAsync(api_ProductByID);
            string data = await respone.Content.ReadAsStringAsync();
            var options = new JsonSerializerOptions{PropertyNameCaseInsensitive = true};
            Product productnew = JsonSerializer.Deserialize<Product>(data, options);
            List<Notification> notifications = HttpContext.Session.GetObjectFromJson<List<Notification>>("Notifications");
            string number = HttpContext.Session.GetString("NumberNoti");
            var viewModel = new ListModels
            {
                product = productnew,
                Notifications = notifications,
                NumberNoti = number
            };
            return View(viewModel);
        }
    //     public async Task<ActionResult> Create()
    //     {
    //         ViewBag.CategoryID = await GetSelectItem();
    //         List<Notification> notifications = HttpContext.Session.GetObjectFromJson<List<Notification>>("Notifications");
    //         var viewModel = new ListModels
    //         {
    //             Notifications = notifications
    //         };
    //         return View(viewModel);
    //     }

    //    [HttpPost] 
    //     public async Task<ActionResult> Create(ListModels obj)
    //     {
    //         System.Console.WriteLine("Test");
    //         if (ModelState.IsValid)
    //         {
    //            string data = JsonSerializer.Serialize(obj.product); 
    //            var content = new StringContent(data, System.Text.Encoding.UTF8, "application/json");
    //            HttpResponseMessage respone = await client.PostAsync(api, content);
    //            if (respone.StatusCode == System.Net.HttpStatusCode.Created)
    //            {
    //             return RedirectToAction("Index");
    //            }
    //         }
    //         return View(obj);
    //     }
    //     public async Task<ActionResult> Edit(int? id)
    //     {
    //         api_ProductByID = $"https://localhost:5002/api/Product/id?id={id}";
    //         HttpResponseMessage respone = await client.GetAsync(api_ProductByID);
    //         string data = await respone.Content.ReadAsStringAsync();
    //         var options = new JsonSerializerOptions{PropertyNameCaseInsensitive = true};
    //         Product productnew = JsonSerializer.Deserialize<Product>(data, options);
    //         ViewBag.CategoryID = await GetSelectItem();
    //         List<Notification> notifications = HttpContext.Session.GetObjectFromJson<List<Notification>>("Notifications");
    //         var viewModel = new ListModels
    //         {
    //             product = productnew,
    //             Notifications = notifications
    //         };
    //         return View(viewModel);
    //     }
        
    //     [HttpPost]
    //     public async Task<ActionResult> Edit(int? id, ListModels obj){
    //         api_ProductByID = $"https://localhost:5002/api/Product/id?id={id}";
    //         if (ModelState.IsValid)
    //         {
    //            string data = JsonSerializer.Serialize(obj.product); 
    //            var content = new StringContent(data, System.Text.Encoding.UTF8, "application/json");
    //            HttpResponseMessage respone = await client.PutAsync(api_ProductByID, content);
    //            if (respone.StatusCode == System.Net.HttpStatusCode.Created)
    //            {
    //             return RedirectToAction("Index");
    //            }
    //         }
    //         return View(obj);
    //     }

    //     public async Task<ActionResult> Delete(int? id)
    //     {
    //         api_ProductByID = $"https://localhost:5002/api/Product/id?id={id}";
    //         HttpResponseMessage respone = await client.GetAsync(api_ProductByID);
    //         string data = await respone.Content.ReadAsStringAsync();
    //         var options = new JsonSerializerOptions{PropertyNameCaseInsensitive = true};
    //         Product productnew = JsonSerializer.Deserialize<Product>(data, options);
    //         List<Notification> notifications = HttpContext.Session.GetObjectFromJson<List<Notification>>("Notifications");
    //         var viewModel = new ListModels
    //         {
    //             product = productnew,
    //             Notifications = notifications
    //         };
    //         return View(viewModel);
    //     }
        
    //     [HttpPost]
    //     public async Task<ActionResult> Delete(int id){
    //         api_ProductByID = $"https://localhost:5002/api/Product/id?id={id}";
    //         try
    //         {
    //             // Tạo yêu cầu DELETE
    //             HttpResponseMessage response = await client.DeleteAsync(api_ProductByID);

    //             // Kiểm tra kết quả trả về từ endpoint API
    //             if (response.IsSuccessStatusCode)
    //             {
    //                 // Xử lý kết quả nếu xóa thành công, ví dụ chuyển hướng đến trang danh sách
    //                 return RedirectToAction("Index");
    //             }
    //             else
    //             {
    //                 // Xử lý kết quả nếu xóa không thành công, ví dụ hiển thị thông báo lỗi
    //                 return View("Error");
    //             }
    //         }
    //         catch (Exception ex)
    //         {
    //             // Xử lý lỗi nếu có
    //             System.Console.WriteLine(ex);
    //             return View("Error");
    //         }
    //     }
        public async Task<List<Category>> GetCategory(){
            HttpResponseMessage respone = await client.GetAsync(apiCategory);
            string data = await respone.Content.ReadAsStringAsync();
            var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            List<Category> list = JsonSerializer.Deserialize<List<Category>>(data, options);
            return list;
        }
        public async Task<List<SelectListItem>> GetSelectItem(){
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
    }
}
