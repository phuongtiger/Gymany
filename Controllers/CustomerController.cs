using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using Microsoft.Extensions.Logging;
using Newtonsoft.Json.Linq;

namespace Gymany.Controllers
{
    public class CustomerController : Controller
    {

        private readonly HttpClient client = null;
        private string apiCustomer;
        private string apiWorkoutPlan;
        private string api_CustomerByID;
        private string api_WorkoutPlanByID;
        private string api_MemberByCusID;
        private string api_WorkoutPlanByMemberID;
        private string apiMember;

        public CustomerController()
        {
            client = new HttpClient();
            var contentType = new MediaTypeWithQualityHeaderValue("application/json");
            client.DefaultRequestHeaders.Accept.Add(contentType);
            this.apiCustomer = "https://localhost:5002/api/Customer";
            this.api_CustomerByID = "https://localhost:5002/api/Customer/id";
            this.api_WorkoutPlanByID = "https://localhost:5002/api/WorkoutPlan/id";
            this.api_MemberByCusID = "https://localhost:5002/api/Member/customerID";
            this.api_WorkoutPlanByMemberID = "https://localhost:5002/api/WorkoutPlan/memberID";
            this.apiMember = "https://localhost:5002/api/Member";
        }
        public IActionResult Form()
        {
            ListModels model = new ListModels();
            return View(model);
        }
        public async Task<ActionResult> Profile()
        {
            if (!checkLogin())
            {
                return RedirectToAction("Form");
            }
            string id = HttpContext.Session.GetString("CustomerID");
            ViewBag.ID = id;
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
            var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            Customer customernew = JsonSerializer.Deserialize<Customer>(data, options);
            var viewModel = new ListModels
            {
                customer = customernew
            };
            // ViewBag.CutomerID = await GetSelectItem();
            return View(viewModel);
        }

        [HttpPost]
        public async Task<ActionResult> EditProfile(int? id, ListModels obj)
        {
            api_CustomerByID = $"https://localhost:5002/api/Customer/id?id={id}";
            Customer customer = obj.customer;
            System.Console.WriteLine(obj.customer.Phone);
            string data = JsonSerializer.Serialize(customer);
            var content = new StringContent(data, System.Text.Encoding.UTF8, "application/json");
            HttpResponseMessage respone = await client.PutAsync(api_CustomerByID, content);
            if (respone.StatusCode == System.Net.HttpStatusCode.Created)
            {
                return RedirectToAction("Profile");
            }
            return View(obj);
        }

     public async Task<IActionResult> JoinMember()
        {
            if (!checkLogin())
            {
                return RedirectToAction("Form");
            }
            string id = HttpContext.Session.GetString("CustomerID");
            ViewBag.cusID = id;
            ListModels listModels= new ListModels();
            api_MemberByCusID = $"https://localhost:5002/api/Member/customerID?customerID={id}";
            HttpResponseMessage response = await client.GetAsync(api_MemberByCusID);
            string data = await response.Content.ReadAsStringAsync();
         
            if (response.StatusCode == HttpStatusCode.NotFound)
            {
                return View(listModels);    
            }
            else
            {
                return RedirectToAction("Profile", "Customer");
            }}
     
       [HttpPost]
        public async Task<IActionResult> JoinMember(ListModels obj)
        {
            if (ModelState.IsValid)
            {

                string data = JsonSerializer.Serialize(obj.member);
                var content = new StringContent(data, System.Text.Encoding.UTF8, "application/json");
                HttpResponseMessage response = await client.PostAsync(apiMember, content);
                if (response.StatusCode == System.Net.HttpStatusCode.Created)
                    return RedirectToAction("Profile","Customer");
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
                return RedirectToAction("Index", "Notification");
            }
            else
            {
                ViewData["Error"] = "Invalid username or password";
                return RedirectToAction("Form");
            }
        }





        public IActionResult PTLogin()
        {
            ListModels model = new ListModels();
            return View(model);
        }

        public IActionResult RegisterForm()
        {
            
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> RegisterForm(Customer obj)
        {
            if (ModelState.IsValid)
            {

                string data = JsonSerializer.Serialize(obj);
                var content = new StringContent(data, System.Text.Encoding.UTF8, "application/json");
                HttpResponseMessage response = await client.PostAsync(apiCustomer, content);
                if (response.StatusCode == System.Net.HttpStatusCode.Created)
                    return RedirectToAction("Form");
            }
            return View(obj);
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

        public async Task<IActionResult> DeleteSession()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "Home");
        }

    }

}