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
        private string apiOrder;
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
            this.apiOrder = "https://localhost:5002/api/Order";

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
            List<Notification> notifications = HttpContext.Session.GetObjectFromJson<List<Notification>>("Notifications");
            string number = HttpContext.Session.GetString("NumberNoti");
            var viewModel = new ListModels
            {
                NumberNoti = number,
                Notifications = notifications,
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
            string data = JsonSerializer.Serialize(customer);
            var content = new StringContent(data, System.Text.Encoding.UTF8, "application/json");
            HttpResponseMessage respone = await client.PutAsync(api_CustomerByID, content);
            if (respone.StatusCode == System.Net.HttpStatusCode.Created)
            {
                return RedirectToAction("Profile");
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


        public async Task<IActionResult> JoinMember()
        {
            if (!checkLogin())
            {
                return RedirectToAction("Form");
            }
            string id = HttpContext.Session.GetString("CustomerID");
            ViewBag.cusID = id;
            List<Notification> notifications = HttpContext.Session.GetObjectFromJson<List<Notification>>("Notifications");
            string number = HttpContext.Session.GetString("NumberNoti");
            ListModels listModels = new ListModels{
                NumberNoti = number,
                Notifications = notifications
            
            };
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
            }
        }

        [HttpPost]
        public async Task<IActionResult> JoinMember(ListModels obj)
        {
            if (ModelState.IsValid)
            {
                Order order = new Order();
                order.ProductID = 1024;
                order.Quantity = 1;
                order.Status = "Pending";
                order.StartDate = DateTime.Now;
                order.CustomerID = int.Parse(HttpContext.Session.GetString("CustomerID"));
                order.Total = 200000;
                string dataMember = JsonSerializer.Serialize(obj.member);
                var contentMember = new StringContent(dataMember, System.Text.Encoding.UTF8, "application/json");
                HttpResponseMessage responseMember = await client.PostAsync(apiMember, contentMember);
                if (responseMember.StatusCode == System.Net.HttpStatusCode.Created)
                {
                    string dataOrder = JsonSerializer.Serialize(order);
                    var contentOrder = new StringContent(dataOrder, System.Text.Encoding.UTF8, "application/json");
                    HttpResponseMessage responseOrder = await client.PostAsync(apiOrder, contentOrder);
                    if (responseOrder.StatusCode == System.Net.HttpStatusCode.Created)
                    {
                        string dataNew = await responseOrder.Content.ReadAsStringAsync();
                        JObject jsonObject = JObject.Parse(dataNew);
                        int idOrder = (int)jsonObject["id"];
                        List<int> listOrderID = new List<int>();
                        listOrderID.Add(idOrder);
                        HttpContext.Session.SetString("IsMember", "false");
                        HttpContext.Session.SetObjectAsJson("listOrderID", listOrderID);
                        return RedirectToAction("Payment", "Payment");
                    }
                }
            }
            return View(obj);
        }


        public IActionResult PTLogin()
        {
            ListModels model = new ListModels();
            return View(model);
        }

        public IActionResult RegisterForm()
        {
            List<Notification> notifications = HttpContext.Session.GetObjectFromJson<List<Notification>>("Notifications");
            string number = HttpContext.Session.GetString("NumberNoti");
            ListModels listModels = new ListModels{
                NumberNoti = number,
                Notifications = notifications
            };
            return View(listModels);
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




        public async Task<IActionResult> DeleteSession()
        {
            // if(HttpContext.Session.GetString("Username")!= null){
            //     HttpContext.Session.Remove("Username");
            // }else
            // {
            //     return RedirectToAction("Profile");
            // }
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "Home");
        }

        public async Task<List<Order>> GetOrder()
        {
            string id = HttpContext.Session.GetString("CustomerID");
            apiOrder = $"https://localhost:5002/api/Order/GetCusId?CustomerID={id}";
            HttpResponseMessage respone = await client.GetAsync(apiOrder);
            string data = await respone.Content.ReadAsStringAsync();
            List<Order> orders = new List<Order>();
            if (respone.StatusCode == HttpStatusCode.NotFound)
            {
                Console.WriteLine("Không có dữ liệu trong giỏ hàng.");
                return new List<Order>();
            }else{
                var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
                orders = JsonSerializer.Deserialize<List<Order>>(data, options);
                if (orders == null)
                {
                    // Thông báo khi danh sách Orders là null
                    Console.WriteLine("Danh sách giỏ hàng trống.");
                    return new List<Order>();
                }

                return orders;
            }
            
        }

        public async Task<IActionResult> OrderHistory()
        {
            // Kiểm tra xem người dùng đã đăng nhập chưa
            if (!checkLogin())
            {
                return RedirectToAction("Form", "Customer");
            }

            // Gọi phương thức GetOrder để lấy danh sách đơn hàng
            List<Order> orders = await GetOrder();

            // Tạo viewModel chứa danh sách đơn hàng
            List<Notification> notifications = HttpContext.Session.GetObjectFromJson<List<Notification>>("Notifications");
            string number = HttpContext.Session.GetString("NumberNoti");
            var viewModel = new ListModels
            {
                NumberNoti = number,
                Notifications = notifications,
                Orders = orders
            };

            // Chuyển đến view "OrderHistory" và truyền viewModel
            return View("OrderHistory", viewModel);
        }   
        public async Task<ActionResult> FogotPassword()
        {
            ListModels listModels = new ListModels();
            return View(listModels);
        }

        [HttpPost]
        public async Task<ActionResult> FogotPassword(string email)
        {
            apiCustomer = $"https://localhost:5002/api/Customer/forgotpassword?email={email}";

            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.PostAsync(apiCustomer, null);

                if (response.IsSuccessStatusCode)
                {
                    return RedirectToAction("Form");
                }
            }

            return RedirectToAction("FogotPassword");
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