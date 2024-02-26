using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Threading.Tasks;
using Gymany.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Gymany.Controllers
{
    [Area("PT")]
    public class PTController : Controller
    {
        private readonly HttpClient client = null;
        private string api;
        private string api_GetCustomerByID;
        private string api_post;
        private string api_PT;
        private string api_GetPostID;
        public PTController()
        {
            client = new HttpClient();
            var contentType = new MediaTypeWithQualityHeaderValue("application/json");
            client.DefaultRequestHeaders.Accept.Add(contentType);
            this.api = "https://localhost:5002/api/Member";
            this.api_GetCustomerByID = "https://localhost:5002/api/Customer/id";
            this.api_post = "https://localhost:5002/api/Post";
            this.api_PT = "https://localhost:5002/api/PT";
            this.api_GetPostID = "https://localhost:5002/api/Post/id";
        }
        public async Task<IActionResult> Index()
        {
            HttpResponseMessage response = await client.GetAsync(api);
            string data = await response.Content.ReadAsStringAsync();
            var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            List<Member> list = JsonSerializer.Deserialize<List<Member>>(data, options);
            return View(list);
        }
        public async Task<IActionResult> PostManage()
        {
            HttpResponseMessage response = await client.GetAsync(api_post);
            string data = await response.Content.ReadAsStringAsync();
            var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            List<Post> list = JsonSerializer.Deserialize<List<Post>>(data, options);
            return View(list);
        }
        public async Task<ActionResult> MemberDetail(int? id)
        {
            api_GetCustomerByID = $"https://localhost:5002/api/Customer/id?id={id}";
            HttpResponseMessage respone = await client.GetAsync(api_GetCustomerByID);
            string data = await respone.Content.ReadAsStringAsync();
            var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            Customer customer = JsonSerializer.Deserialize<Customer>(data, options);
            return View(customer);
        }

        public async Task<IActionResult> CreatePost()
        {
            ViewBag.PTID = await GetPTNameSelected();
            return View();
        }

        [HttpPost]

        public async Task<IActionResult> CreatePost(Post obj)
        {
            if (ModelState.IsValid)
            {

                string data = JsonSerializer.Serialize(obj);
                var content = new StringContent(data, System.Text.Encoding.UTF8, "application/json");
                HttpResponseMessage response = await client.PostAsync(api_post, content);
                if (response.StatusCode == System.Net.HttpStatusCode.Created)
                    return RedirectToAction("PostManage");
            }
            return View(obj);
        }

        public async Task<ActionResult> DeletePost(int? id)
        {
            api_GetPostID = $"https://localhost:5002/api/Post/id?id={id}";
            HttpResponseMessage respone = await client.GetAsync(api_GetPostID);
            string data = await respone.Content.ReadAsStringAsync();
            var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            Post post = JsonSerializer.Deserialize<Post>(data, options);
            return View(post);
        }

        [HttpPost]
        public async Task<ActionResult> DeletePost(int id)
        {
            api_GetPostID = $"https://localhost:5002/api/Post/id?id={id}";
            try
            {
                // Tạo yêu cầu DELETE
                HttpResponseMessage response = await client.DeleteAsync(api_GetPostID);

                // Kiểm tra kết quả trả về từ endpoint API
                if (response.IsSuccessStatusCode)
                {
                    // Xử lý kết quả nếu xóa thành công, ví dụ chuyển hướng đến trang danh sách
                    return RedirectToAction("PostManage");
                }
                else
                {
                    // Xử lý kết quả nếu xóa không thành công, ví dụ hiển thị thông báo lỗi
                    return View("Error");
                }
            }
            catch (Exception ex)
            {
                // Xử lý lỗi nếu có
                return View("Error");
            }
        }

        public async Task<ActionResult> EditPost(int? id)
        {
            api_GetPostID = $"https://localhost:5002/api/Post/id?id={id}";
            HttpResponseMessage respone = await client.GetAsync(api_GetPostID);
            string data = await respone.Content.ReadAsStringAsync();
            var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            Post post = JsonSerializer.Deserialize<Post>(data, options);
            ViewBag.PTID = await GetPTNameSelected();
            return View(post);
        }

        [HttpPost]
        public async Task<ActionResult> EditPost(int? id, Post obj)
        {
            api_GetPostID = $"https://localhost:5002/api/Post/id?id={id}";
            if (ModelState.IsValid)
            {
                string data = JsonSerializer.Serialize(obj);
                var content = new StringContent(data, System.Text.Encoding.UTF8, "application/json");
                HttpResponseMessage respone = await client.PutAsync(api_GetPostID, content);
                if (respone.StatusCode == System.Net.HttpStatusCode.Created)
                {
                    return RedirectToAction("PostManage");
                }
            }
            return View(obj);
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

        public async Task<List<SelectListItem>> GetPTNameSelected()
        {
            HttpResponseMessage respone = await client.GetAsync(api_PT);
            string data = await respone.Content.ReadAsStringAsync();
            var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            List<PersonalTrainer> list = JsonSerializer.Deserialize<List<PersonalTrainer>>(data, options);
            List<SelectListItem> yourData = list.Select(c => new SelectListItem
            {
                Value = c.PTID.ToString(), // ID của category là giá trị của mục
                Text = c.Name // Tên của category là nội dung của mục
            }).ToList();
            return yourData;
        }

    }
}