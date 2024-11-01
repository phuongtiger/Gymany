using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using Gymany.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Gymany.Core.Service;
using Gymany.Core.Constant;

namespace Gymany.Controllers
{
    [Route("[controller]")]
    public class NotificationController : Controller
    {
        private readonly ApiService _apiService;
        public NotificationController(ApiService apiService)
        {
            _apiService = apiService;
        }
        public async Task<ActionResult> Index()
        {
            string id = HttpContext.Session.GetString(SessionConstant.CUSTOMER_ID);
            List<Notification> list = await _apiService.GetAsync<List<Notification>>(ApiEndpoints.NOTIFICATION_BY_ID + id);
            HttpContext.Session.SetObjectAsJson(SessionConstant.NOTIFICATION_LIST, list);
            int count = 0;
            foreach (var item in list)
            {
                count++;
            }
            HttpContext.Session.SetString(SessionConstant.NOTIFICATION_NUMBER, Convert.ToString(count));
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