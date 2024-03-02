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
    public class CartController : Controller
    {
        
        private readonly HttpClient client = null;
        private string api_CartById;
        public CartController()
        {
            client = new HttpClient();
            var contentType = new MediaTypeWithQualityHeaderValue("application/json");
            client.DefaultRequestHeaders.Accept.Add(contentType);
            this.api_CartById = "https://localhost:5002/api/Cart";
        }
       public async Task<ActionResult> Index()
        {
            HttpResponseMessage respone = await client.GetAsync(api_CartById);
            string data = await respone.Content.ReadAsStringAsync();
            var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            List<Cart> list = JsonSerializer.Deserialize<List<Cart>>(data, options);
            ListModels model = new ListModels{
                Notifications = HttpContext.Session.GetObjectFromJson<List<Notification>>("Notifications"),
                NumberNoti = HttpContext.Session.GetString("NumberNoti"),
            };
            return View(model);
        }
     


    }
}