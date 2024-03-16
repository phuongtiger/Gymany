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
namespace Gymany.Controllers
{
    [Route("[controller]")]
    public class NotificationController : Controller
    {
        private readonly HttpClient client = null;
        private string api;
        public NotificationController(){
            client = new HttpClient();
            var contentType = new MediaTypeWithQualityHeaderValue("application/json");
            client.DefaultRequestHeaders.Accept.Add(contentType);
            this.api = "https://localhost:5002/api/Notification";
        }
        public async Task<ActionResult> Index(string controllerRoute, string actionRoute)
        {
            string id = HttpContext.Session.GetString("CustomerID");
            api = $"https://localhost:5002/api/Notification/id?id={id}";
            HttpResponseMessage respone = await client.GetAsync(api);
            string data = await respone.Content.ReadAsStringAsync();
            var options = new JsonSerializerOptions{PropertyNameCaseInsensitive = true};
            List<Notification> list = JsonSerializer.Deserialize<List<Notification>>(data, options);
            HttpContext.Session.SetObjectAsJson("Notifications", list);
            int count = 0;
            foreach (var item in list)
            {
                count++;
            }
            HttpContext.Session.SetString("NumberNoti", Convert.ToString(count));
            return RedirectToAction("Index", "Home");
        }
    }
    public static class SessionExtensions
    {
        public static void SetObjectAsJson(this ISession session, string key, object value)
        {
            session.SetString(key, JsonSerializer.Serialize(value));
        }

        public static T GetObjectFromJson<T>(this ISession session, string key)
        {
            var value = session.GetString(key);
            return value == null ? default : JsonSerializer.Deserialize<T>(value);
        }
    }
}