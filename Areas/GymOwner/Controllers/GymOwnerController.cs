using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Security.Claims;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Gymany.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;

namespace Gymany.Controllers
{
    [Area("GymOwner")]
    public class GymOwnerController : Controller
    {
        private readonly HttpClient client = null;

        private string api;
        private string api_ProductByID;
        private string apiCategory;
        private string api_GymOwner;

        private string api_Customer;

        private string api_CustomerById;

        private string api_PersonalTrainer;

        private string api_PersonalTrainerById;

        private string api_Post;

        private string api_PostById;

        private string api_Staff;

        private string api_StaffById;
        public GymOwnerController()
        {
            client = new HttpClient();
            var contentType = new MediaTypeWithQualityHeaderValue("application/json");
            client.DefaultRequestHeaders.Accept.Add(contentType);
            this.api = "https://localhost:5002/api/Product";
            this.api_ProductByID = "https://localhost:5002/api/Product/id";
            this.apiCategory = "https://localhost:5002/api/Category";
            this.api_GymOwner = "https://localhost:5002/api/GymOwner/checklogin";

            this.api_Customer = "https://localhost:5002/api/Customer";
            this.api_CustomerById = "https://localhost:5002/api/Customer/id";
            this.api_PersonalTrainer = "https://localhost:5002/api/PT";
            this.api_PersonalTrainerById = "https://localhost:5002/api/PT/id";
            this.api_Post = "https://localhost:5002/api/Post";
            this.api_PostById = "https://localhost:5002/api/Post/id";
            this.api_Staff = "https://localhost:5002/api/Staff";
            this.api_StaffById = "https://localhost:5002/api/Staff/api";

        }

        // ------------------page of admin after login successfull-------------------------
        public IActionResult Home()
        {
            if (!checkLogin())
            {
                return Redirect("/GymOwner/Index");
            }
            return View("Home", "GymManageLayout");
        }


        //page login for admin 
        public IActionResult Index()
        {
            return View(new GymOwner());
        }
        [HttpPost]
        public async Task<IActionResult> Login(string username, string password)
        {
            api_GymOwner = $"https://localhost:5002/api/GymOwner/checklogin?username={username}&password={password}";
            var gymOwner = new GymOwner { Username = username, Password = password };
            var content = new StringContent(JsonSerializer.Serialize(gymOwner), Encoding.UTF8, "application/json");
            HttpResponseMessage response = await client.PostAsync(api_GymOwner, content);
            if (response.IsSuccessStatusCode)
            {
                // var user = await response.Content.ReadFromJsonAsync<GymOwner>();
                // Lưu thông tin người dùng vào session hoặc cookie
                HttpContext.Session.SetString("Username", username);
                HttpContext.Session.SetString("Password", password);
                // Chuyển hướng đến trang chủ
                return RedirectToAction("Home", "GymOwner");
            }
            else
            {
                System.Console.WriteLine("2");
                Console.WriteLine($"Error: {response.StatusCode}");
                // Hiển thị thông báo lỗi
                ViewData["Error"] = "Invalid username or password";
                return View("Index", gymOwner);
            }
        }


        //-------------------Produc Page-----------------------------
        public async Task<IActionResult> Product()
        {
            if (!checkLogin())
            {
                return Redirect("/GymOwner/Index");
            }
            HttpResponseMessage response = await client.GetAsync(api);
            string data = await response.Content.ReadAsStringAsync();
            var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            List<Product> list = JsonSerializer.Deserialize<List<Product>>(data, options);
            return View(list);

        }
        public async Task<IActionResult> AddProductAsync()
        {
            ViewBag.CategoryID = await GetSelectItem();
            // TODO: Your code here
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddProduct(Product obj)
        {
            ViewBag.CategoryID = await GetSelectItem();
            if (ModelState.IsValid)
            {

                string data = JsonSerializer.Serialize(obj);
                var content = new StringContent(data, System.Text.Encoding.UTF8, "application/json");
                HttpResponseMessage response = await client.PostAsync(api, content);

                if (response.StatusCode == System.Net.HttpStatusCode.Created)
                    return RedirectToAction("Product");
            }
            return View(obj);
        }
        public async Task<IActionResult> UpdateProduct(int id)
        {

            api_ProductByID = $"https://localhost:5002/api/Product/id?id={id}";
            HttpResponseMessage response = await client.GetAsync(api_ProductByID);

            ViewBag.ProductID = id;
            ViewBag.CategoryID = await GetSelectItem();


            if (response.IsSuccessStatusCode)
            {
                var data = response.Content.ReadAsStringAsync().Result;
                var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
                var product = JsonSerializer.Deserialize<Product>(data, options);
                return View(product);
            }
            return NotFound();
        }
        [HttpPost]
        public async Task<IActionResult> UpdateProduct(int id, Product obj)
        {
            api_ProductByID = $"https://localhost:5002/api/Product/id?id={id}";
            obj.ProductID = id;
            ViewBag.ProductID = id;
            ViewBag.CategoryID = await GetSelectItem();
            string data = JsonSerializer.Serialize(obj);
            var content = new StringContent(data, System.Text.Encoding.UTF8, "application/json");
            HttpResponseMessage response = await client.PutAsync(api_ProductByID, content);
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("Product");
            }
            return Redirect("UpdateProduct");
        }

        public async Task<IActionResult> DeleteProduct(int id)
        {
            api_ProductByID = $"https://localhost:5002/api/Product/id?id={id}";
            HttpResponseMessage response = await client.GetAsync(api_ProductByID);
            if (response.IsSuccessStatusCode)
            {
                var data = response.Content.ReadAsStringAsync().Result;
                var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
                var product = JsonSerializer.Deserialize<Product>(data, options);
                return View(product);
            }
            return NotFound();
        }
        [HttpPost]
        public async Task<ActionResult> DeleteProduct(int id, Product obj)
        {
            api_ProductByID = $"https://localhost:5002/api/Product/id?id={id}";

            try
            {
                // Tạo yêu cầu DeleteProduct
                obj.ProductID = id;
                HttpResponseMessage response = await client.DeleteAsync(api_ProductByID);
                var data = response.Content.ReadAsStringAsync().Result;
                var product = JsonSerializer.Deserialize<Product>(data);
                // Kiểm tra kết quả trả về từ endpoint API
                if (response.IsSuccessStatusCode)
                {
                    // Xử lý kết quả nếu xóa thành công, ví dụ chuyển hướng đến trang danh sách
                    return RedirectToAction("Product");

                }
                else
                {
                    // Xử lý kết quả nếu xóa không thành công, ví dụ hiển thị thông báo lỗi
                    return View();
                }
            }
            catch (Exception ex)
            {
                // Xử lý lỗi nếu có
                System.Console.WriteLine(ex);
                return View("Error");
            }
        }


        //-----------------Account Customer Page----------------------------------
        public async Task<IActionResult> CustomerAccout()
        {
            if (!checkLogin())
            {
                return Redirect("/GymOwner/Index");
            }
            HttpResponseMessage response = await client.GetAsync(api_Customer);
            string data = await response.Content.ReadAsStringAsync();
            var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            List<Customer> list = JsonSerializer.Deserialize<List<Customer>>(data, options);
            return View(list);

        }
        //add customer
        public IActionResult AddCustomerAccout()
        {
            // TODO: Your code here
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddCustomerAccout(Customer obj)
        {
            if (ModelState.IsValid)
            {
                string data = JsonSerializer.Serialize(obj);
                var content = new StringContent(data, System.Text.Encoding.UTF8, "application/json");
                HttpResponseMessage response = await client.PostAsync(api_Customer, content);
                if (response.StatusCode == System.Net.HttpStatusCode.Created)
                    return RedirectToAction("CustomerAccout");
            }
            return View(obj);
        }


        //update customer
        public async Task<IActionResult> UpdateCustomerAccout(int id)
        {
            api_CustomerById = $"https://localhost:5002/api/Customer/id?id={id}";
            HttpResponseMessage response = await client.GetAsync(api_CustomerById);
            ViewBag.CustomerID = id;
            ViewBag.CategoryID = await GetSelectItem();
            if (response.IsSuccessStatusCode)
            {
                var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
                var data = response.Content.ReadAsStringAsync().Result;
                var product = JsonSerializer.Deserialize<Customer>(data, options);
                return View(product);
            }
            return NotFound();
        }
        [HttpPost]
        public async Task<IActionResult> UpdateCustomerAccout(int id, Customer obj)
        {
            api_CustomerById = $"https://localhost:5002/api/Customer/id?id={id}";
            obj.CustomerID = id;
            string data = JsonSerializer.Serialize(obj);
            var content = new StringContent(data, System.Text.Encoding.UTF8, "application/json");
            HttpResponseMessage response = await client.PutAsync(api_CustomerById, content);
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("CustomerAccout");
            }
            return Redirect("UpdateCustomerAccout");
        }

        //method delete customer
        public async Task<IActionResult> DeleteCustomerAccout(int id)
        {
            api_CustomerById = $"https://localhost:5002/api/Customer/id?id={id}";
            HttpResponseMessage response = await client.GetAsync(api_CustomerById);
            if (response.IsSuccessStatusCode)
            {
                var data = response.Content.ReadAsStringAsync().Result;
                var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
                var customer = JsonSerializer.Deserialize<Customer>(data, options);
                return View(customer);
            }
            return NotFound();
        }
        [HttpPost]
        public async Task<ActionResult> DeleteCustomerAccout(int id, Customer obj)
        {
            api_CustomerById = $"https://localhost:5002/api/Customer/id?id={id}";

            try
            {
                // Tạo yêu cầu DeleteProduct
                obj.CustomerID = id;
                HttpResponseMessage response = await client.DeleteAsync(api_CustomerById);
                var data = response.Content.ReadAsStringAsync().Result;
                var customer = JsonSerializer.Deserialize<Customer>(data);
                // Kiểm tra kết quả trả về từ endpoint API
                if (response.IsSuccessStatusCode)
                {
                    // Xử lý kết quả nếu xóa thành công, ví dụ chuyển hướng đến trang danh sách
                    return RedirectToAction("Customer ");

                }
                else
                {
                    // Xử lý kết quả nếu xóa không thành công, ví dụ hiển thị thông báo lỗi
                    return View();
                }
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex);
                // Xử lý lỗi nếu có
                return View("Error");
            }
        }


        //---------------------------Personal trainer account-----------------------

        public async Task<IActionResult> PersonalTrainer()
        {
            if (!checkLogin())
            {
                return Redirect("/GymOwner/Index");
            }
            HttpResponseMessage response = await client.GetAsync(api_PersonalTrainer);
            string data = await response.Content.ReadAsStringAsync();
            var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            List<PersonalTrainer> list = JsonSerializer.Deserialize<List<PersonalTrainer>>(data, options);
            return View(list);

        }
        //method acc pt accout
        public IActionResult AddPtAccout()
        {
            // TODO: Your code here
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddPtAccout(PersonalTrainer obj)
        {
            if (ModelState.IsValid)
            {
                string data = JsonSerializer.Serialize(obj);
                var content = new StringContent(data, System.Text.Encoding.UTF8, "application/json");
                HttpResponseMessage response = await client.PostAsync(api_PersonalTrainer, content);
                if (response.StatusCode == System.Net.HttpStatusCode.Created)
                    return RedirectToAction("PersonalTrainer");
            }
            return View(obj);
        }
        //method update pt accout
        public async Task<IActionResult> UpdatePtAccout(int id)
        {
            api_PersonalTrainerById = $"https://localhost:5002/api/PT/id?id={id}";
            HttpResponseMessage response = await client.GetAsync(api_PersonalTrainerById);
            ViewBag.PTID = id;

            if (response.IsSuccessStatusCode)
            {
                var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
                var data = response.Content.ReadAsStringAsync().Result;
                var pt = JsonSerializer.Deserialize<PersonalTrainer>(data, options);
                return View(pt);
            }
            return NotFound();
        }
        [HttpPost]
        public async Task<IActionResult> UpdatePtAccout(int id, PersonalTrainer obj)
        {
            api_PersonalTrainerById = $"https://localhost:5002/api/PT/id?id={id}";
            obj.PTID = id;
            string data = JsonSerializer.Serialize(obj);
            var content = new StringContent(data, System.Text.Encoding.UTF8, "application/json");
            HttpResponseMessage response = await client.PutAsync(api_PersonalTrainerById, content);
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("PersonalTrainer");
            }
            return Redirect("UpdatePtAccout");
        }
        //method delete Pt accout
        public async Task<IActionResult> DeletePtAccout(int id)
        {
            api_PersonalTrainerById = $"https://localhost:5002/api/PT/id?id={id}";
            HttpResponseMessage response = await client.GetAsync(api_PersonalTrainerById);
            if (response.IsSuccessStatusCode)
            {
                var data = response.Content.ReadAsStringAsync().Result;
                var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
                var pt = JsonSerializer.Deserialize<PersonalTrainer>(data, options);
                return View(pt);
            }
            return NotFound();
        }
        [HttpPost]
        public async Task<ActionResult> DeletePtAccout(int id, PersonalTrainer obj)
        {
            api_PersonalTrainerById = $"https://localhost:5002/api/PT/id?id={id}";

            try
            {
                // Tạo yêu cầu DeletePT
                obj.PTID = id;
                HttpResponseMessage response = await client.DeleteAsync(api_PersonalTrainerById);
                var data = response.Content.ReadAsStringAsync().Result;
                var pt = JsonSerializer.Deserialize<PersonalTrainer>(data);
                // Kiểm tra kết quả trả về từ endpoint API
                if (response.IsSuccessStatusCode)
                {
                    // Xử lý kết quả nếu xóa thành công, ví dụ chuyển hướng đến trang danh sách
                    return RedirectToAction("PersonalTrainer");

                }
                else
                {
                    // Xử lý kết quả nếu xóa không thành công, ví dụ hiển thị thông báo lỗi
                    return View();
                }
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex);
                // Xử lý lỗi nếu có
                return View("Error");
            }
        }
        //---------------------------Post Managae -----------------------
        public async Task<IActionResult> Post()
        {
            if (!checkLogin())
            {
                return Redirect("/GymOwner/Index");
            }
            HttpResponseMessage response = await client.GetAsync(api_Post);
            string data = await response.Content.ReadAsStringAsync();
            var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            List<Post> list = JsonSerializer.Deserialize<List<Post>>(data, options);
            return View(list);

        }
        //method acc pt accout
        public async Task<IActionResult> AddPost()
        {
            ViewBag.Name = await GetPtId();
            ViewBag.NameStaff = await GetStaffId();
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddPost(Post obj)
        {
            ViewBag.Name = await GetPtId();
            ViewBag.NameStaff = await GetStaffId();
            if (ModelState.IsValid)
            {
                string data = JsonSerializer.Serialize(obj);
                var content = new StringContent(data, System.Text.Encoding.UTF8, "application/json");
                HttpResponseMessage response = await client.PostAsync(api_Post, content);
                if (response.StatusCode == System.Net.HttpStatusCode.Created)
                    return RedirectToAction("Post");
            }
            return View(obj);
        }
        //method update pt accout
        public async Task<IActionResult> UpdatePost(int id)
        {
            ViewBag.Name = await GetPtId();
            ViewBag.NameStaff = await GetStaffId();
            api_Post = $"https://localhost:5002/api/Post/id?id={id}";
            HttpResponseMessage response = await client.GetAsync(api_Post);
            ViewBag.PostID = id;

            if (response.IsSuccessStatusCode)
            {
                var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
                var data = response.Content.ReadAsStringAsync().Result;
                var post = JsonSerializer.Deserialize<Post>(data, options);
                return View(post);
            }
            return NotFound();
        }
        [HttpPost]
        public async Task<IActionResult> UpdatePost(int id, Post obj)
        {
            ViewBag.Name = await GetPtId();
            ViewBag.NameStaff = await GetStaffId();
            api_Post = $"https://localhost:5002/api/Post/id?id={id}";
            obj.PostID = id;
            string data = JsonSerializer.Serialize(obj);
            var content = new StringContent(data, System.Text.Encoding.UTF8, "application/json");
            HttpResponseMessage response = await client.PutAsync(api_Post, content);
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("Post");
            }
            return View("UpdatePost");
        }

        //method delete Pt accout
        public async Task<IActionResult> DeletePost(int id)
        {
            api_Post = $"https://localhost:5002/api/Post/id?id={id}";
            HttpResponseMessage response = await client.GetAsync(api_Post);
            if (response.IsSuccessStatusCode)
            {
                var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
                var data = response.Content.ReadAsStringAsync().Result;
                var post = JsonSerializer.Deserialize<Post>(data, options);
                return View(post);
            }
            return NotFound();
        }
        [HttpPost]
        public async Task<ActionResult> DeletePost(int id, Post obj)
        {
            api_Post = $"https://localhost:5002/api/Post/id?id={id}";

            try
            {
                // Tạo yêu cầu DeletePT
                obj.PostID = id;
                HttpResponseMessage response = await client.DeleteAsync(api_Post);
                var data = response.Content.ReadAsStringAsync().Result;
                var post = JsonSerializer.Deserialize<Post>(data);
                // Kiểm tra kết quả trả về từ endpoint API
                if (response.IsSuccessStatusCode)
                {
                    // Xử lý kết quả nếu xóa thành công, ví dụ chuyển hướng đến trang danh sách
                    return RedirectToAction("Post");

                }
                else
                {
                    // Xử lý kết quả nếu xóa không thành công, ví dụ hiển thị thông báo lỗi
                    return View();
                }
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex);
                // Xử lý lỗi nếu có
                return View("Error");
            }
        }







        // ========================== another medthod ==========================================\\
        public async Task<List<SelectListItem>> GetSelectItem()
        {
            HttpResponseMessage respone = await client.GetAsync(apiCategory);
            string data = await respone.Content.ReadAsStringAsync();
            var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            List<Category> list = JsonSerializer.Deserialize<List<Category>>(data, options);
            List<SelectListItem> yourData = list.Select(c => new SelectListItem
            {
                Value = c.CategoryID.ToString(), // ID của category là giá trị của mục
                Text = c.Type // Tên của category là nội dung của mục
            }).ToList();
            return yourData;
        }

        public async Task<List<SelectListItem>> GetPtId()
        {
            HttpResponseMessage respone = await client.GetAsync(api_PersonalTrainer);
            string data = await respone.Content.ReadAsStringAsync();
            var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            List<PersonalTrainer> list = JsonSerializer.Deserialize<List<PersonalTrainer>>(data, options);
            List<SelectListItem> yourData = list.Select(c => new SelectListItem
            {
                Value = c.PTID.ToString(), // ID của category là giá trị của mục
                Text = c.Name // Tên của category là nội dung của mục
            }).ToList();
            return yourData;
        }
        public async Task<List<SelectListItem>> GetStaffId()
        {
            HttpResponseMessage respone = await client.GetAsync(api_Staff);
            string data = await respone.Content.ReadAsStringAsync();
            var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            List<Staff> list = JsonSerializer.Deserialize<List<Staff>>(data, options);
            List<SelectListItem> yourData = list.Select(c => new SelectListItem
            {
                Value = c.StaffID.ToString(), // ID của category là giá trị của mục
                Text = c.Name // Tên của category là nội dung của mục
            }).ToList();
            return yourData;
        }



        //method check session
        public bool checkLogin()
        {
            var email = HttpContext.Session.GetString("Username");
            var pass = HttpContext.Session.GetString("Password");
            if (email != null && pass != null)
            {
                return true;
            }
            return false;
        }

    }
}