using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Gymany.Core.Constant;
using Gymany.Core.Service;
using Gymany.Models;
using Gymany.Models.Response;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;

namespace Gymany.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ApiService _apiService;
        public CustomerController(ApiService apiService)
        {
            _apiService = apiService;

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
            Customer customer = await _apiService.GetAsync<Customer>(ApiEndpoints.CUSTOMER_BY_ID + id);
            List<Notification> notifications = HttpContext.Session.GetObjectFromJson<List<Notification>>("Notifications");
            string number = HttpContext.Session.GetString("NumberNoti");
            var viewModel = new ListModels
            {
                customer = customer,
                Notifications = notifications,
                NumberNoti = number
            };
            return View(viewModel);
        }

        public async Task<ActionResult> EditProfile(int? id)
        {
            Customer customer = await _apiService.GetAsync<Customer>(ApiEndpoints.CUSTOMER_BY_ID + id);
            List<Notification> notifications = HttpContext.Session.GetObjectFromJson<List<Notification>>("Notifications");
            string number = HttpContext.Session.GetString("NumberNoti");
            var viewModel = new ListModels
            {
                NumberNoti = number,
                Notifications = notifications,
                customer = customer
            };
            // ViewBag.CutomerID = await GetSelectItem();
            return View(viewModel);
        }

        [HttpPost]
        public async Task<ActionResult> EditProfile(int? id, ListModels obj)
        {
            CustomerResponse response = await _apiService.PutAsync<CustomerResponse, Customer>(ApiEndpoints
                .CUSTOMER_BY_ID + id, obj.customer);
            if (response.StatusCode == System.Net.HttpStatusCode.Created)
            {
                TempData["SuccessMessage"] = "Your changes have been saved successfully.";
                return RedirectToAction("EditProfile");
            }
            return View(obj);
        }

     // ------------------------------view payment history------------------
        public async Task<List<Payment>> GetPayment()
        {
            string id = HttpContext.Session.GetString("CustomerID");
            try
            {
                List<Payment> payments = await _apiService.GetAsync<List<Payment>>(ApiEndpoints.PAYMENT_BY_ID + id);
                if (payments == null)
                {
                    return new List<Payment>();
                }

                return payments;
            }
            catch (Exception e)
            {
                System.Console.WriteLine(e.Message);
                return  new List<Payment>();
            }
        }


        public async Task<IActionResult> PaymentHistory()
        {
            // Kiểm tra xem người dùng đã đăng nhập chưa
            if (!checkLogin())
            {
                return RedirectToAction("Form", "Customer");
            }

            // Gọi phương thức GetOrder để lấy danh sách đơn hàng
            List<Payment> payments = await GetPayment();

            // Tạo viewModel chứa danh sách đơn hàng
            var viewPayment = new ListModels
            {
                Payments = payments
            };

            // Chuyển đến view "OrderHistory" và truyền viewModel
            return View("PaymentHistory", viewPayment);
        }


        public async Task<ActionResult> Login(string username, string password)
        {
            var customer = new Customer { cus_username = username, cus_password = password};
            CustomerResponse response = await _apiService.PostAsync<CustomerResponse, Customer>(ApiEndpoints
                .GetCustomerCheckLoginUrl(username, password), customer);
            if (response.StatusCode == HttpStatusCode.OK && response.token != null)
            {
                HttpContext.Session.SetString("token", response.token);
                HttpContext.Session.SetString("CustomerID", response.CustomerID.ToString());
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewData["Error"] = "Invalid username or password";
                return RedirectToAction("Form");
            }
        }


        // public async Task<IActionResult> JoinMember()
        // {
        //     if (!checkLogin())
        //     {
        //         return RedirectToAction("Form");
        //     }
        //     string id = HttpContext.Session.GetString("CustomerID");
        //     ViewBag.cusID = id;
        //     List<Notification> notifications = HttpContext.Session.GetObjectFromJson<List<Notification>>("Notifications");
        //     string number = HttpContext.Session.GetString("NumberNoti");
        //     ListModels listModels = new ListModels
        //     {
        //         NumberNoti = number,
        //         Notifications = notifications

        //     };
        //     api_MemberByCusID = $"https://localhost:5002/api/Member/customerID?customerID={id}";
        //     HttpResponseMessage response = await client.GetAsync(api_MemberByCusID);
        //     if (response.StatusCode == HttpStatusCode.NotFound)
        //     {
        //         return View(listModels);
        //     }
        //     else
        //     {
        //         return RedirectToAction("Profile", "Customer");
        //     }
        // }

        // [HttpPost]
        // public async Task<IActionResult> JoinMember(ListModels obj)
        // {
        //     if (ModelState.IsValid)
        //     {
        //         Order order = new Order();
        //         order.prod_id = 1024;
        //         order.order_quantity = 1;
        //         order.order_status = "Waiting";
        //         order.order_startDate = DateTime.Now;
        //         order.cus_id = int.Parse(HttpContext.Session.GetString("CustomerID"));
        //         order.order_totalPrice = 200000;
        //         string Cuid = HttpContext.Session.GetString("CustomerID");
        //         string api = $"https://localhost:5002/api/Member/customerID?CustomerID={Cuid}";
        //         HttpResponseMessage response = await client.GetAsync(api);
        //         if (response.StatusCode == HttpStatusCode.NotFound)
        //         {
        //             string dataMember = JsonSerializer.Serialize(obj.member);
        //             var contentMember = new StringContent(dataMember, System.Text.Encoding.UTF8, "application/json");
        //             HttpResponseMessage responseMember = await client.PostAsync(apiMember, contentMember);
        //         }

        //         string dataOrder = JsonSerializer.Serialize(order);
        //         var contentOrder = new StringContent(dataOrder, System.Text.Encoding.UTF8, "application/json");
        //         HttpResponseMessage responseOrder = await client.PostAsync(apiOrder, contentOrder);
        //         if (responseOrder.StatusCode == System.Net.HttpStatusCode.Created)
        //         {
        //             string dataNew = await responseOrder.Content.ReadAsStringAsync();
        //             JObject jsonObject = JObject.Parse(dataNew);
        //             int idOrder = (int)jsonObject["id"];
        //             List<int> listOrderID = new List<int>();
        //             listOrderID.Add(idOrder);
        //             HttpContext.Session.SetString("IsMember", "false");
        //             HttpContext.Session.SetObjectAsJson("listOrderID", listOrderID);
        //             return RedirectToAction("Payment", "Payment");
        //         }
        //     }
        //     return View(obj);
        // }

        public IActionResult PTLogin()
        {
            ListModels model = new ListModels();
            return View(model);
        }

        public IActionResult RegisterForm()
        {
            List<Notification> notifications = HttpContext.Session.GetObjectFromJson<List<Notification>>("Notifications");
            string number = HttpContext.Session.GetString("NumberNoti");
            ListModels listModels = new ListModels
            {
                NumberNoti = number,
                Notifications = notifications
            };
            return View(listModels);
        }

        [HttpPost]
        public async Task<IActionResult> RegisterForm(ListModels obj)
        {
            bool isUserNameExist = await IsUsernameExist(obj.customer.cus_username);
            if (ModelState.IsValid && !isUserNameExist)
            {
                BaseResponse response = await  _apiService.PostAsync<BaseResponse, Customer>(ApiEndpoints.CUSTOMER, obj.customer);
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    ViewData["Success"] = "Register success";
                    ListModels listModels = new ListModels();
                    return View("Form", listModels);
                }
            }
            ViewData["Message"] = "Username or Email is exist";
            return View(obj);
        }
        public async Task<bool> IsUsernameExist(string username)
        {
            BaseResponse response = await _apiService.GetAsync<BaseResponse>(ApiEndpoints.CUSTOMER_CHECK_USERNAME + username);

            if (response.status == 200)
            {
                return true;
            }
            return false;
        }
        public IActionResult PTPage()
        {
            return Redirect(Url.Action("PTLogin", "PT", new { area = "PT" }));
        }


        public async Task<IActionResult> DeleteSession()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "Home");
        }

        public async Task<List<Order>> GetOrder()
        {
            string id = HttpContext.Session.GetString("CustomerID");
            try
            {
                List<Order> orders = await _apiService.GetAsync<List<Order>>(ApiEndpoints.ORDER_BY_CUSTOMER + id);
                if (orders == null)
                {
                    orders = new List<Order>();
                }
                return orders;
            }
            catch (Exception e)
            {
                System.Console.WriteLine(e.Message);
                return  new List<Order>();
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
            try {
                ListModels listModels = new ListModels();
                BaseResponse response = await _apiService.PostAsync<BaseResponse, string>(ApiEndpoints.CUSTOMER_FORGET_PASSWORD + email, email);

                if (response != null)
                {
                    ViewData["Success"] = "Please check your email to reset password";
                    return View("Form", listModels);
                }else{
                    ViewData["Error"] = "Email does not exist";
                    return View("FogotPassword", listModels);
                }
            }
            catch (JsonException jsonEx)
            {
                // Trả về một view lỗi hoặc thông báo lỗi cho người dùng
                ViewData["Error"] = jsonEx.ToString();
                return View("FogotPassword", new ListModels());
            }
            catch (Exception ex)
            {
                // Trả về một view lỗi hoặc thông báo lỗi cho người dùng
                ViewData["Error"] = "An error occurred while processing your request. Please try again later.";
                return View("FogotPassword", new ListModels());
            }
        }

        public bool checkLogin()
        {
            var token = HttpContext.Session.GetString("token");
            if (token != null)
            {
                return true;
            }
            return false;
        }

    }

}