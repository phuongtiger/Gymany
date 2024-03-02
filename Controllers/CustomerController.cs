using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Gymany.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json.Linq;

namespace Gymany.Controllers
{
    public class CustomerController : Controller
    {

         private readonly HttpClient client = null;
        private string apiCustomer;
        private string api_CustomerByID;

          public CustomerController(){
            client = new HttpClient();
            var contentType = new MediaTypeWithQualityHeaderValue("application/json");
            client.DefaultRequestHeaders.Accept.Add(contentType);
            this.apiCustomer = "https://localhost:5002/api/Customer";
            this.api_CustomerByID="https://localhost:5002/api/Customer/id";
           
        }
        public IActionResult Form(){
            ListModels model = new ListModels();
            return View(model);
        }
           public async Task<ActionResult> Profile()
        {
            if(!checkLogin()){
                    return RedirectToAction("Form");
            }
            string id = HttpContext.Session.GetString("CustomerID");
            api_CustomerByID = $"https://localhost:5002/api/Customer/id?id={id}";
            HttpResponseMessage respone = await client.GetAsync(api_CustomerByID);
            string data = await respone.Content.ReadAsStringAsync();
            var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            Customer customernew = JsonSerializer.Deserialize<Customer>(data, options);
            List<Notification> notifications = HttpContext.Session.GetObjectFromJson<List<Notification>>("Notifications");
            string number = HttpContext.Session.GetString("NumberNoti");
            var viewModel = new ListModels
            {
                customer = customernew,
                Notifications = notifications,
                NumberNoti = number
            };
            return View(viewModel);
        }

            public async Task<ActionResult> EditProfile(int? id)
        {
            api_CustomerByID = $"https://localhost:5002/api/Customer/id?id={id}";
            HttpResponseMessage respone = await client.GetAsync(api_CustomerByID);
            string data = await respone.Content.ReadAsStringAsync();
            var options = new JsonSerializerOptions{PropertyNameCaseInsensitive = true};
            Customer customer = JsonSerializer.Deserialize<Customer>(data, options);
            // ViewBag.CutomerID = await GetSelectItem();
            return View(customer);
        }
        
        [HttpPost]
        public async Task<ActionResult> EditProfile(int? id, Customer obj){
            api_CustomerByID = $"https://localhost:5002/api/Customer/id?id={id}";
            if (ModelState.IsValid)
            {
               string data = JsonSerializer.Serialize(obj); 
               var content = new StringContent(data, System.Text.Encoding.UTF8, "application/json");
               HttpResponseMessage respone = await client.PutAsync(api_CustomerByID, content);
               if (respone.StatusCode == System.Net.HttpStatusCode.Created)
               {
                return RedirectToAction("Profile");
               }
            }
            return View(obj);
        }

    public async Task<ActionResult> Login(string username, string password)
        {
            apiCustomer = $"https://localhost:5002/api/Customer/checklogin?username={username}&password={password}";
            var customer = new Customer { Username = username, Password = password };
            var content = new StringContent(JsonSerializer.Serialize(customer), Encoding.UTF8, "application/json");
            HttpResponseMessage response = await client.PostAsync(apiCustomer, content);
            if (response.IsSuccessStatusCode)
            {
                string jsonString = await response.Content.ReadAsStringAsync();
                //lấy tất cả thông tin từ id của customer
                JObject jsonObject = JObject.Parse(jsonString);
                string id = (string)jsonObject["customerID"];

                HttpContext.Session.SetString("CustomerID", id);
                HttpContext.Session.SetString("Username", username);
                HttpContext.Session.SetString("Password", password);
                // Chuyển hướng đến trang chủ
                return RedirectToAction("Index","Notification");
            }
            else
            {
                ViewData["Error"] = "Invalid username or password";
                return RedirectToAction("Form");
            }
        }
   

   


        public IActionResult PTLogin()
        {
            var viewModel = new ListModels();
            return View(viewModel);
        }

        public IActionResult Register()
        {
            var viewModel = new ListModels();
            return View(viewModel);
        }

        public IActionResult PTPage()
        {
            return Redirect(Url.Action("PTLogin", "PT", new { area = "PT" }));
        }
        

    [HttpPost]
        public bool checkLogin()
        {
            var username = HttpContext.Session.GetString("Username");
            var pass = HttpContext.Session.GetString("Password");
            if (username != null && pass != null)
            {
                return true;
            }
            return false;
        }
    }

}