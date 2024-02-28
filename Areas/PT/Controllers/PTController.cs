using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Gymany.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json.Linq;

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
        private string api_GetPostPTID;
        public PTController()
        {
            client = new HttpClient();
            var contentType = new MediaTypeWithQualityHeaderValue("application/json");
            client.DefaultRequestHeaders.Accept.Add(contentType);
            this.api = "https://localhost:5002/api/Member";
            // this.api_GetCustomerByID = "https://localhost:5002/api/Customer/id";
            this.api_post = "https://localhost:5002/api/Post";
            this.api_PT = "https://localhost:5002/api/PT";
            this.api_GetPostID = "https://localhost:5002/api/Post/id";
        }
        public async Task<IActionResult> Index()
        {
            if (!checkLogin())
            {
                return RedirectToAction("PTLogin");
            }
            HttpResponseMessage response = await client.GetAsync(api);
            string data = await response.Content.ReadAsStringAsync();
            var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            List<Member> list = JsonSerializer.Deserialize<List<Member>>(data, options);
            return View(list);
        }
        public async Task<IActionResult> PostManage()
        {
            if (!checkLogin())
            {
                return RedirectToAction("PTLogin");
            }
            string id = HttpContext.Session.GetString("ID");

            // Kiểm tra xem ID có tồn tại không
            if (!string.IsNullOrEmpty(id))
            {
            }
            else
            {
                // ID không tồn tại trong Session, xử lý tùy ý
                return RedirectToAction("PTLogin");
            }
            api_GetPostPTID = $"https://localhost:5002/api/Post/ptid?ptid={id}";
            HttpResponseMessage response = await client.GetAsync(api_GetPostPTID);
            if (response.StatusCode == HttpStatusCode.NotFound)
            {
                return View();
            }else{
                string data = await response.Content.ReadAsStringAsync();
                var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
                List<Post> list = JsonSerializer.Deserialize<List<Post>>(data, options);
                return View(list);
            }
        }

        public IActionResult PTProfile()
        {
            if (!checkLogin())
            {
                return RedirectToAction("PTLogin");
            }
            return View();
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

        public IActionResult CreatePost()
        {
            // Gọi PTID đã lữu trong session
            int ptid = Convert.ToInt32(HttpContext.Session.GetString("ID"));

            // Gán PTID vào ViewBag để sử dụng trong view
            ViewBag.PTID = ptid;
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
                System.Console.WriteLine(ex);
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
            api_GetPostID = $"https://localhost:5002/api/Post/Id?id={id}";
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

            return Redirect(Url.Action("Login", "Customer"));
        }

        public IActionResult PTRegister()
        {

            return View();
        }

        public async Task<ActionResult> PTLogin(string email, string password)
        {
            api_post = $"https://localhost:5002/api/PT/checklogin?email={email}&password={password}";
            var gymOwner = new GymOwner { Username = email, Password = password };
            var content = new StringContent(JsonSerializer.Serialize(gymOwner), Encoding.UTF8, "application/json");
            HttpResponseMessage response = await client.PostAsync(api_post, content);
            if (response.IsSuccessStatusCode)
            {
                string jsonString = await response.Content.ReadAsStringAsync();

                JObject jsonObject = JObject.Parse(jsonString);

                // Lấy giá trị của trường "id"
                string id = (string)jsonObject["ptid"];

                HttpContext.Session.SetString("ID", id);
                HttpContext.Session.SetString("Email", email);
                HttpContext.Session.SetString("Password", password);
                // Chuyển hướng đến trang chủ
                return RedirectToAction("Index");
            }
            else
            {
                Console.WriteLine($"Error: {response.StatusCode}");
                // Hiển thị thông báo lỗi
                ViewData["Error"] = "Invalid username or password";
                return View("PTLogin");
            }
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


        [HttpPost]
        public bool checkLogin()
        {
            var email = HttpContext.Session.GetString("Email");
            var pass = HttpContext.Session.GetString("Password");
            if (email != null && pass != null)
            {
                return true;
            }
            return false;
        }

    }
}