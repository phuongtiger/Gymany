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
using Newtonsoft.Json.Linq;

namespace Gymany.Controllers
{
    public class CartController : Controller
    {

        private readonly HttpClient client = null;
        private string api_CartById;
        private string api;
        private string api_order;

        public CartController()
        {
            client = new HttpClient();
            var contentType = new MediaTypeWithQualityHeaderValue("application/json");
            client.DefaultRequestHeaders.Accept.Add(contentType);
            this.api_CartById = $"https://localhost:5002/api/Cart/CustomerID";
            this.api = $"https://localhost:5002/api/Cart";
            this.api_order = $"https://localhost:5002/api/Order";
            client.BaseAddress = new Uri("https://localhost:5002");
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }



        public async Task<List<Cart>> GetCart()
        {
            string id = HttpContext.Session.GetString("CustomerID");
            api_CartById = $"https://localhost:5002/api/Cart/CustomerID?CustomerID={id}";
            HttpResponseMessage respone = await client.GetAsync(api_CartById);
            string data = await respone.Content.ReadAsStringAsync();

            if (string.IsNullOrEmpty(data))
            {
                // Thông báo khi dữ liệu không có
                Console.WriteLine("Không có dữ liệu trong giỏ hàng.");
                return new List<Cart>();
            }

            var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            List<Cart> carts = JsonSerializer.Deserialize<List<Cart>>(data, options);

            if (carts == null)
            {
                // Thông báo khi danh sách carts là null
                Console.WriteLine("Danh sách giỏ hàng trống.");
                return new List<Cart>();
            }

            return carts;
        }

        public async Task<List<Order>> GetOrder()
        {
            string id = HttpContext.Session.GetString("CustomerID");
            api_CartById = $"https://localhost:5002/api/Order/CustomerID?CustomerID={id}";
            HttpResponseMessage respone = await client.GetAsync(api_CartById);
            string data = await respone.Content.ReadAsStringAsync();

            if (string.IsNullOrEmpty(data))
            {
                // Thông báo khi dữ liệu không có
                Console.WriteLine("Không có dữ liệu trong giỏ hàng.");
                return new List<Order>();
            }

            var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            List<Order> orders = JsonSerializer.Deserialize<List<Order>>(data, options);

            if (orders == null)
            {
                // Thông báo khi danh sách Orders là null
                Console.WriteLine("Danh sách giỏ hàng trống.");
                return new List<Order>();
            }

            return orders;
        }



        public async Task<ActionResult> Index()
        {
            if (!checkLogin())
            {
                return RedirectToAction("Form", "Customer");
            }
            List<Cart> carts = await GetCart();
            var viewModel = new ListModels
            {
                Carts = carts
            };
            return View(viewModel);
        }


        [HttpPost]
        public IActionResult PaymentProcess(string paymentMethod, string paymentLanguage){
            if (!checkLogin())
            {
                return RedirectToAction("Form", "Customer");
            }
            if(paymentMethod.Equals("methodVNPAY")){
                return RedirectToAction("Payment", "Payment");
            }else if(paymentMethod.Equals("methodCash")){
                return RedirectToAction("OrderHistory", "Customer");
            }
            return View();
        }
        public async Task<ActionResult> Create()
        {
            ListModels listModels = new ListModels();
            List<int> ListOrder = HttpContext.Session.GetObjectFromJson<List<int>>("listOrderID");
            List<Order> OrderPayment = new List<Order>();
            int total = 0;
            foreach (var item in ListOrder)
            {   
                string api_Order = $"https://localhost:5002/api/Order/id?id={item}";
                HttpResponseMessage respone = await client.GetAsync(api_Order);
                string data = await respone.Content.ReadAsStringAsync();
                var options = new JsonSerializerOptions{PropertyNameCaseInsensitive = true};
                Order Order = JsonSerializer.Deserialize<Order>(data, options);
                total += (int)Order.Total;
                OrderPayment.Add(Order);
            }
            ViewBag.Total = total;
            return View(listModels);
        }

        [HttpPost]
        public async Task<ActionResult> Create(Cart obj)
        {
            if (!checkLogin())
            {
                return Redirect("Cart/Form");
            }
            if (ModelState.IsValid)
            {
                string data = JsonSerializer.Serialize(obj);
                var content = new StringContent(data, System.Text.Encoding.UTF8, "application/json");
                HttpResponseMessage respone = await client.PostAsync(api, content);
                if (respone.StatusCode == System.Net.HttpStatusCode.Created)
                {
                    
                    return RedirectToAction("Index");
                }
            }
            return View(obj);
        }

        public async Task<IActionResult> CreateOrder()
        {
            if (!checkLogin())
            {
                return RedirectToAction("Form", "Customer");
            }
            try
            {
                string id = HttpContext.Session.GetString("CustomerID");
                api_CartById = $"https://localhost:5002/api/Order/CustomerID?CustomerID={id}";
                HttpResponseMessage respone = await client.GetAsync(api_CartById);
                string data = await respone.Content.ReadAsStringAsync();
                var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
                List<int> listOrderID = JsonSerializer.Deserialize<List<int>>(data, options);
                HttpContext.Session.SetObjectAsJson("listOrderID", listOrderID);
                if (respone.IsSuccessStatusCode)
                {
                    return RedirectToAction("Create");
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Failed to copy data from Cart to Order.");
                    return View("Error");
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(string.Empty, $"Error: {ex.Message}");
                return View("Error");
            }
        }

        [HttpPost]
        public async Task<IActionResult> AddToCart(int productId)
        {
            try
            {
                 var customerId = HttpContext.Session.GetString("CustomerID");
                var response = await client.PostAsync($"api/Cart/CreateCartByCustomerID?customerID={customerId}&productID={productId}", null);

                if (response.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index", "Product"); // Redirect to home page or wherever you want after adding to cart
                }
                else
                {
                    // Handle unsuccessful response
                    return RedirectToAction("Error", "Home"); // Redirect to error page or handle the error accordingly
                }
            }
            catch (Exception ex)
            {
                // Log the error for troubleshooting
                Console.WriteLine($"Error: {ex.Message}");
                return RedirectToAction("Error", "Home"); // Redirect to error page or handle the error accordingly
            }
        }

        [HttpPost]
        public async Task<ActionResult> UpdateCartItem(int cartID, int quantity)
        {
            try
            {
                var response = await client.PostAsync($"api/Cart/UpdateCartItem?cartID={cartID}&quantity={quantity}", null);
                
                if (response.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index", "Home"); // Hoặc chuyển hướng đến trang khác
                }
                else
                {
                    // Xử lý trường hợp không thành công
                    ModelState.AddModelError(string.Empty, "Failed to update cart item.");
                    return View(); // Hoặc trả về view với thông báo lỗi
                }
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ
                ModelState.AddModelError(string.Empty, $"Error: {ex.Message}");
                return View(); // Hoặc trả về view với thông báo lỗi
            }
        }



        [HttpPost]
        public async Task<ActionResult> Delete(int CartId){
            api = $"https://localhost:5002/api/Cart/id?id={CartId}";
            try
            {
                // Tạo yêu cầu DELETE
                HttpResponseMessage response = await client.DeleteAsync(api);

                // Kiểm tra kết quả trả về từ endpoint API
                if (response.IsSuccessStatusCode)
                {
                    // Xử lý kết quả nếu xóa thành công, ví dụ chuyển hướng đến trang danh sách
                    return RedirectToAction("Index");
                }
                else
                {
                    // Xử lý kết quả nếu xóa không thành công, ví dụ hiển thị thông báo lỗi
                    return View("Error");
                }
            }
            catch (Exception ex)
            {
                // Xử lý lỗi nếu có
                System.Console.WriteLine(ex);
                return View("Error");
            }
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