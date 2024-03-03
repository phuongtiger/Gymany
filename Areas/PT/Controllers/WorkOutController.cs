using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Threading.Tasks;
using Gymany.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;

namespace Gymany.Areas.PT.Controllers
{
    [Area("PT")]
    public class WorkOutController : Controller
    {
        private readonly HttpClient client = null;
        private string api;
        private string api_WOID;
        private string api_memid;
        public WorkOutController()
        {
            client = new HttpClient();
            var contentType = new MediaTypeWithQualityHeaderValue("application/json");
            client.DefaultRequestHeaders.Accept.Add(contentType);
            this.api = "https://localhost:5002/api/WorkoutPlan";
            this.api_memid = "https://localhost:5002/api/Member";
            this.api_WOID = "https://localhost:5002/api/WorkoutPlan/ptid";
        }


        public async Task<IActionResult> Index()
        {
            if (!checkLogin())
            {
                return Redirect("PT/Form");
            }
            string id = HttpContext.Session.GetString("ID");

            api_WOID = $"https://localhost:5002/api/WorkoutPlan/ptid?ptid={id}";
            HttpResponseMessage response = await client.GetAsync(api_WOID);
            if (response.StatusCode == HttpStatusCode.NotFound)
            {
                return View();
            }
            else
            {
                string data = await response.Content.ReadAsStringAsync();
                var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
                List<WorkoutPlan> list = JsonSerializer.Deserialize<List<WorkoutPlan>>(data, options);
                return View(list);
            }
        }
        public async Task<IActionResult> Create()
        {
            if (!checkLogin())
            {
                return Redirect("PT/Form");
            }
            string id = HttpContext.Session.GetString("ID");
            ViewBag.cusid = await GetCusNameSelected();
            ViewBag.PTID = id;
            return View();
        }

        [HttpPost]

        public async Task<IActionResult> Create(WorkoutPlan obj)
        {
            if (ModelState.IsValid)
            {

                string data = JsonSerializer.Serialize(obj);
                var content = new StringContent(data, System.Text.Encoding.UTF8, "application/json");
                HttpResponseMessage response = await client.PostAsync(api, content);
                if (response.StatusCode == System.Net.HttpStatusCode.Created)
                    return RedirectToAction("index");
            }
            return View(obj);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (!checkLogin())
            {
                return Redirect("PT/Form");
            }
            api = $"https://localhost:5002/api/WorkoutPlan/id?id={id}";
            HttpResponseMessage respone = await client.GetAsync(api);
            string data = await respone.Content.ReadAsStringAsync();
            var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            WorkoutPlan workoutPlan = JsonSerializer.Deserialize<WorkoutPlan>(data, options);
            return View(workoutPlan);
        }

        [HttpPost]
        public async Task<ActionResult> Delete(int id)
        {
            api = $"https://localhost:5002/api/WorkoutPlan/id?id={id}";
            try
            {
                // Tạo yêu cầu DELETE
                HttpResponseMessage response = await client.DeleteAsync(api);

                // Kiểm tra kết quả trả về từ endpoint API
                if (response.IsSuccessStatusCode)
                {
                    // Xử lý kết quả nếu xóa thành công, ví dụ chuyển hướng đến trang danh sách
                    return RedirectToAction("Index");
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

        public async Task<ActionResult> Edit(int? id)
        {
            if (!checkLogin())
            {
                return Redirect("PT/Form");
            }
            api = $"https://localhost:5002/api/WorkoutPlan/id?id={id}";
            HttpResponseMessage respone = await client.GetAsync(api);
            string data = await respone.Content.ReadAsStringAsync();
            var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            WorkoutPlan workoutPlan = JsonSerializer.Deserialize<WorkoutPlan>(data, options);
            return View(workoutPlan);
        }

        [HttpPost]
        public async Task<ActionResult> Edit(int? id, WorkoutPlan obj)
        {
            api = $"https://localhost:5002/api/WorkoutPlan/Id?id={id}";
            if (ModelState.IsValid)
            {
                string data = JsonSerializer.Serialize(obj);
                var content = new StringContent(data, System.Text.Encoding.UTF8, "application/json");
                HttpResponseMessage respone = await client.PutAsync(api, content);
                if (respone.StatusCode == System.Net.HttpStatusCode.Created)
                {
                    return RedirectToAction("index");
                }
            }
            return View(obj);
        }

        public async Task<List<SelectListItem>> GetCusNameSelected()
        {
            HttpResponseMessage respone = await client.GetAsync(api_memid);
            string data = await respone.Content.ReadAsStringAsync();
            var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            List<Member> list = JsonSerializer.Deserialize<List<Member>>(data, options);
            List<SelectListItem> yourData = list.Select(c => new SelectListItem
            {
                Value = c.MemberID.ToString(), // ID của category là giá trị của mục
                Text = Convert.ToString(c.MemberID) // Tên của category là nội dung của mục
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