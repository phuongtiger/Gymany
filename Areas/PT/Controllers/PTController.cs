using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Threading.Tasks;
using Gymany.Models;
using Microsoft.AspNetCore.Mvc;

namespace Gymany.Controllers
{
    [Area("PT")]
    public class PTController : Controller
    {
        private readonly HttpClient client = null;
        private string api;
        private string api_GetCustomerByID;
        private string api_post;
        public PTController()
        {
            client = new HttpClient();
            var contentType = new MediaTypeWithQualityHeaderValue("application/json");
            client.DefaultRequestHeaders.Accept.Add(contentType);
            this.api = "https://localhost:5002/api/Member";
            this.api_GetCustomerByID = "https://localhost:5002/api/Customer/id";
            this.api_post = "https://localhost:5002/api/Post";
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

        public IActionResult CreatePost()
        {
            // TODO: Your code here
            return View();
        }

        [HttpPost]

        public async Task<IActionResult> CreatePost(Post obj){          
            if(ModelState.IsValid)
            {
                
                string data=JsonSerializer.Serialize(obj);
                var content= new StringContent(data, System.Text.Encoding.UTF8,"application/json");
                HttpResponseMessage response =await client.PostAsync(api, content);
                if (response.StatusCode==System.Net.HttpStatusCode.Created)
                return RedirectToAction("Index");
            }
            return View(obj);
         }
        
        public IActionResult DeletePost()
        {
            // TODO: Your code here
            return View();
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

        public IActionResult ActionName()
        {
            // TODO: Your code here
            return View();
        }

    }
}