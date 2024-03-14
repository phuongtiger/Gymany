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
        private string api_Nof;
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
            this.api_Nof = "https://localhost:5002/api/Notification";
            this.api_PT = "https://localhost:5002/api/PT";
            this.api_GetPostID = "https://localhost:5002/api/Post/id";
        }
        public async Task<IActionResult> Index()
        {
            if (!checkLogin())
            {
                return RedirectToAction("Form");
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
                return RedirectToAction("Form");
            }
            string id = HttpContext.Session.GetString("ID");

            // Kiểm tra xem ID có tồn tại không
            if (!string.IsNullOrEmpty(id))
            {
            }
            else
            {
                // ID không tồn tại trong Session, xử lý tùy ý
                return RedirectToAction("Form");
            }
            api_GetPostPTID = $"https://localhost:5002/api/Post/ptid?ptid={id}";
            HttpResponseMessage response = await client.GetAsync(api_GetPostPTID);
            if (response.StatusCode == HttpStatusCode.NotFound)
            {
                return View();
            }
            else
            {
                string data = await response.Content.ReadAsStringAsync();
                var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
                List<Post> list = JsonSerializer.Deserialize<List<Post>>(data, options);
                return View(list);
            }
        }

        public async Task<IActionResult> PTProfileAsync()
        {
            if (!checkLogin())
            {
                return RedirectToAction("Form");
            }
            string ptid = HttpContext.Session.GetString("ID");
            api_PT = $"https://localhost:5002/api/PT/id?id={ptid}";
            HttpResponseMessage response = await client.GetAsync(api_PT);
            string data = await response.Content.ReadAsStringAsync();
            var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            PersonalTrainer pt = JsonSerializer.Deserialize<PersonalTrainer>(data, options);
            return View(pt);
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
            if (!checkLogin())
            {
                return RedirectToAction("Form");
            }
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
            if (!checkLogin())
            {
                return RedirectToAction("Form");
            }
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
            int ptid = Convert.ToInt32(HttpContext.Session.GetString("ID"));
            // Gán PTID vào ViewBag để sử dụng trong view
            ViewBag.PTID = ptid;
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

        public IActionResult SendMessage(int? id)
        {
            int ptid = Convert.ToInt32(HttpContext.Session.GetString("ID"));
            ViewBag.cusid = id;
            ViewBag.ptid = ptid;
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> SendMessage(Notification obj)
        {
            if (ModelState.IsValid)
            {
                obj.Date = DateTime.Now;
                string data = JsonSerializer.Serialize(obj);
                var content = new StringContent(data, System.Text.Encoding.UTF8, "application/json");
                HttpResponseMessage response = await client.PostAsync(api_Nof, content);
                return RedirectToAction("Index");
            }
            return View(obj);
        }

        public IActionResult BackToLogin()
        {

            return Redirect(Url.Action("Login", "Customer"));
        }

        public IActionResult Form()
        {
            return View();
        }

        public async Task<ActionResult> PTLogin(string email, string password)
        {
            api_post = $"https://localhost:5002/api/PT/checklogin?email={email}&password={password}";
            var PT = new PersonalTrainer { Username = email, Password = password };
            var content = new StringContent(JsonSerializer.Serialize(PT), Encoding.UTF8, "application/json");
            HttpResponseMessage response = await client.PostAsync(api_post, content);
            string data = await response.Content.ReadAsStringAsync();
            var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            PersonalTrainer pt = JsonSerializer.Deserialize<PersonalTrainer>(data, options);
            if (response.IsSuccessStatusCode)
            {
                HttpContext.Session.SetString("ID", pt.PTID.ToString());
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
                return View("Form");
            }
        }

        public IActionResult DeleteSession()
        {
            //xóa hết session đang lưu hiện tại
            HttpContext.Session.Clear();
            return View("form");
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