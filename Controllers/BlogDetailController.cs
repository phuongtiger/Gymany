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
    public class BlogDetailController : Controller
    {
        private readonly HttpClient client = null;
        private string api_postID;

        public BlogDetailController()
        {
            client = new HttpClient();
            var contentType = new MediaTypeWithQualityHeaderValue("application/json");
            client.DefaultRequestHeaders.Accept.Add(contentType);
            this.api_postID = $"https://localhost:5002/api/Post/PostID";
        }



        public async Task<List<Post>> GetBlogByPostID()
        {
            string id = HttpContext.Session.GetString("PostID");

            // Kiểm tra tính hợp lệ của id
            if (string.IsNullOrEmpty(id))
            {
                Console.WriteLine("ID bài viết không hợp lệ.");
                return new List<Post>();
            }

            api_postID = $"https://localhost:5002/api/Post/PostID?PostID={id}";
            HttpResponseMessage response = await client.GetAsync(api_postID);

            if (!response.IsSuccessStatusCode)
            {
                Console.WriteLine($"Lỗi khi gọi API: {response.StatusCode}");
                return new List<Post>();
            }

            string data = await response.Content.ReadAsStringAsync();

            if (string.IsNullOrEmpty(data))
            {
                Console.WriteLine("Không có dữ liệu trong phản hồi từ API.");
                return new List<Post>();
            }

            var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };

            try
            {
                List<Post> posts = JsonSerializer.Deserialize<List<Post>>(data, options);
                if (posts == null)
                {
                    Console.WriteLine("Danh sách bài viết từ API là null.");
                    return new List<Post>();
                }
                return posts;
            }
            catch (JsonException ex)
            {
                Console.WriteLine($"Lỗi khi deserialize dữ liệu JSON: {ex.Message}");
                return new List<Post>();
            }
        }



        public async Task<ActionResult> Index()
        {
            List<Post> posts = await GetBlogByPostID();


            List<Notification> notifications = HttpContext.Session.GetObjectFromJson<List<Notification>>("Notifications");
            string number = HttpContext.Session.GetString("NumberNoti");
            var viewModel = new ListModels
            {
                Notifications = notifications,
                NumberNoti = number,
                Posts = posts
            };
            return View(viewModel);
        }


    }
}