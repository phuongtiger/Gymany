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
    public class BlogController : Controller
    {

        private readonly HttpClient client = null;
        private string api;

        public BlogController()
        {
            client = new HttpClient();
            var contentType = new MediaTypeWithQualityHeaderValue("application/json");
            client.DefaultRequestHeaders.Accept.Add(contentType);
            this.api = $"https://localhost:5002/api/Post";
        }


        public async Task<List<Post>> GetBlog()
        {
            HttpResponseMessage respone = await client.GetAsync(api);
            string data = await respone.Content.ReadAsStringAsync();
            var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            List<Post> posts = JsonSerializer.Deserialize<List<Post>>(data, options);
            return posts;
        }


        public async Task<ActionResult> Index()
        {
            List<Post> posts = await GetBlog();

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


        [HttpPost]
        public IActionResult SavePostId(string postID)
        {
            HttpContext.Session.SetString("PostID", postID);
            return Ok();
        }


        // public  async Task<ActionResult> blogdetail(){
        //     List<Post> posts = await GetBlog();


        //     List<Notification> notifications = HttpContext.Session.GetObjectFromJson<List<Notification>>("Notifications");
        //     string number = HttpContext.Session.GetString("NumberNoti");
        //     var viewModel = new ListModels
        //     {
        //         Notifications = notifications,
        //         NumberNoti = number,
        //         Posts = posts
        //     };
        //     return View(viewModel);
        // }
    }
}