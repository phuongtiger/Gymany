using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
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
using X.PagedList;


namespace Gymany.Controllers
{
    [Area("GymOwner")]
    public class GymOwnerController : Controller
    {
        private readonly HttpClient client = null;

        private string api;
        private string api_ProductByID;
        private string apiCategory;
        private string apiCategory_ById;
        private string api_GymOwner;
        private string apiGetGymOwnerByID;

        private string api_Customer;

        private string api_CustomerById;

        private string api_PersonalTrainer;

        private string api_PersonalTrainerById;

        private string api_Post;

        private string api_PostById;

        private string api_Staff;

        private string api_StaffById;

        private string api_Member;

        private string api_MemberById;
        public GymOwnerController()
        {
            client = new HttpClient();
            var contentType = new MediaTypeWithQualityHeaderValue("application/json");
            client.DefaultRequestHeaders.Accept.Add(contentType);
            this.api = "https://localhost:5002/api/Product";
            this.api_ProductByID = "https://localhost:5002/api/Product/id";
            this.apiCategory = "https://localhost:5002/api/Category";
            this.apiCategory_ById = "https://localhost:5002/api/Category/id";
            this.api_GymOwner = "https://localhost:5002/api/GymOwner/checklogin";
            this.apiGetGymOwnerByID = "https://localhost:5002/api/GymOwner";
            this.api_Customer = "https://localhost:5002/api/Customer";
            this.api_CustomerById = "https://localhost:5002/api/Customer/id";
            this.api_PersonalTrainer = "https://localhost:5002/api/PT";
            this.api_PersonalTrainerById = "https://localhost:5002/api/PT/id";
            this.api_Post = "https://localhost:5002/api/Post";
            this.api_PostById = "https://localhost:5002/api/Post/id";
            this.api_Staff = "https://localhost:5002/api/Staff";
            this.api_StaffById = "https://localhost:5002/api/Staff/api";
            this.api_Member = "https://localhost:5002/api/Member";
            this.api_MemberById = "https://localhost:5002/api/Member/id";

        }

        // ------------------page of admin after login successfull-------------------------
        public IActionResult Home()
        {
            if (!checkLogin())
            {
                return Redirect("/GymOwner/Index");
            }
            ViewBag.Name = HttpContext.Session.GetString("GymOwnerName");
            ViewBag.GymOwnerID = HttpContext.Session.GetString("GymOwnerID");
            return View();
        }


        //page login for admin 
        public IActionResult Index(string error = null)
        {
            ViewData["Error"] = error;
            return View(new GymOwner());
        }
        public async Task<IActionResult> Profile()
        {
            if (!checkLogin())
            {
                return Redirect("/GymOwner/Index");
            }
            ViewBag.Name = HttpContext.Session.GetString("GymOwnerName");
            string id = HttpContext.Session.GetString("GymOwnerID");
            apiGetGymOwnerByID = $"https://localhost:5002/api/GymOwner/id?id={id}";
            HttpResponseMessage response = await client.GetAsync(apiGetGymOwnerByID);
            string data = await response.Content.ReadAsStringAsync();
            var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            GymOwner gymOwner = JsonSerializer.Deserialize<GymOwner>(data, options);
            return View(gymOwner);
        }
        [HttpPost]
        public async Task<IActionResult> Profile(GymOwner obj)
        {

            ViewBag.Name = HttpContext.Session.GetString("GymOwnerName");
            string id = HttpContext.Session.GetString("GymOwnerID");
            apiGetGymOwnerByID = $"https://localhost:5002/api/GymOwner/Id?id={id}";
            string data = JsonSerializer.Serialize(obj);
            var content = new StringContent(data, System.Text.Encoding.UTF8, "application/json");
            HttpResponseMessage response = await client.PutAsync(apiGetGymOwnerByID, content);
            if (response.IsSuccessStatusCode)
            {
                HttpContext.Session.SetString("GymOwnerName", obj.Name.ToString());
                return RedirectToAction("Profile");
            }
            return RedirectToAction("Profile");
        }


        [HttpPost]
        public async Task<IActionResult> Login(string username, string password)
        {
            api_GymOwner = $"https://localhost:5002/api/GymOwner/checklogin?username={username}&password={password}";
            var gymOwner = new GymOwner { Username = username, Password = password };
            var content = new StringContent(JsonSerializer.Serialize(gymOwner), Encoding.UTF8, "application/json");
            HttpResponseMessage response = await client.PostAsync(api_GymOwner, content);
            string data = await response.Content.ReadAsStringAsync();
            var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            GymOwner gym = JsonSerializer.Deserialize<GymOwner>(data, options);
            if (response.IsSuccessStatusCode)
            {
                // var user = await response.Content.ReadFromJsonAsync<GymOwner>();
                // Lưu thông tin người dùng vào session hoặc cookie
                HttpContext.Session.SetString("UsernameGymOwner", username);
                HttpContext.Session.SetString("PasswordGymOwner", password);
                HttpContext.Session.SetString("GymOwnerName", gym.Name.ToString());
                HttpContext.Session.SetString("GymOwnerID", gym.AdminID.ToString());
                // Chuyển hướng đến trang chủ
                return RedirectToAction("Home", "GymOwner");
            }
            else
            {
                Console.WriteLine($"Error: {response.StatusCode}");
                // Hiển thị thông báo lỗi
                ViewData["Error"] = "Invalid username or password";
                return View("Index", gymOwner);
            }
        }

        //lougout and delete session
        public IActionResult DeleteSession()
        {
            //xóa hết session đang lưu hiện tại
            HttpContext.Session.Clear();
            return View("Index");
        }

        //-------------------Produc Page-----------------------------
        public async Task<IActionResult> Product(int? page)
        {
            if (!checkLogin())
            {
                return Redirect("/GymOwner/Index");
            }
            HttpResponseMessage response = await client.GetAsync(api);
            string data = await response.Content.ReadAsStringAsync();
            var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            List<Product> list = JsonSerializer.Deserialize<List<Product>>(data, options);
            var listPage = list.ToPagedList(page ?? 1, 3);
            ViewBag.Name = HttpContext.Session.GetString("GymOwnerName");
            return View(listPage);

        }
        public async Task<IActionResult> AddProduct()
        {
            ViewBag.Name = HttpContext.Session.GetString("GymOwnerName");
            ViewBag.CategoryID = await GetSelectItem();
            // TODO: Your code here
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddProduct(Product obj)
        {

            ViewBag.Name = HttpContext.Session.GetString("GymOwnerName");
            ViewBag.CategoryID = await GetSelectItem();
            if (ModelState.IsValid)
            {
                if (obj.ImageUpload != null)
                {
                    string fileName = Path.GetFileNameWithoutExtension(obj.ImageUpload.FileName) + Path.GetExtension(obj.ImageUpload.FileName);
                    string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images/Product", fileName);
                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        await obj.ImageUpload.CopyToAsync(stream);
                    }
                    obj.Image = "/images/Product/" + fileName;

                }
                string data = JsonSerializer.Serialize(obj);
                var content = new StringContent(data, System.Text.Encoding.UTF8, "application/json");
                HttpResponseMessage response = await client.PostAsync(api, content);
                if (response.StatusCode == System.Net.HttpStatusCode.Created)
                {
                    TempData["SuccessMessage"] = "Product added successfully!";
                    return RedirectToAction("Product");
                }

            }
            return View(obj);
        }
        public async Task<IActionResult> UpdateProduct(int id)
        {
            ViewBag.Name = HttpContext.Session.GetString("GymOwnerName");
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
            if (obj.ImageUpload != null)
            {
                string fileName = Path.GetFileNameWithoutExtension(obj.ImageUpload.FileName) + Path.GetExtension(obj.ImageUpload.FileName);
                string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images/Product", fileName);
                using (var stream = new FileStream(path, FileMode.Create))
                {
                    await obj.ImageUpload.CopyToAsync(stream);
                }
                obj.Image = "/images/Product/" + fileName;
            }
            ViewBag.Name = HttpContext.Session.GetString("GymOwnerName");
            api_ProductByID = $"https://localhost:5002/api/Product/id?id={id}";
            obj.ProductID = id;
            ViewBag.ProductID = id;
            ViewBag.CategoryID = await GetSelectItem();
            string data = JsonSerializer.Serialize(obj);
            var content = new StringContent(data, System.Text.Encoding.UTF8, "application/json");
            HttpResponseMessage response = await client.PutAsync(api_ProductByID, content);
            if (response.IsSuccessStatusCode)
            {
                TempData["SuccessMessage"] = "The product has been updated successfully!";
                return RedirectToAction("Product");
            }
            return Redirect("UpdateProduct");
        }

        public async Task<IActionResult> DeleteProduct(int id)
        {
            ViewBag.Name = HttpContext.Session.GetString("GymOwnerName");
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
            ViewBag.Name = HttpContext.Session.GetString("GymOwnerName");
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
                    TempData["SuccessMessage"] = "The product has been successfully deleted!";
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
        public async Task<IActionResult> CustomerAccount(int? page)
        {
            ViewBag.Name = HttpContext.Session.GetString("GymOwnerName");
            if (!checkLogin())
            {
                return Redirect("/GymOwner/Index");
            }
            HttpResponseMessage response = await client.GetAsync(api_Customer);
            string data = await response.Content.ReadAsStringAsync();
            var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            List<Customer> list = JsonSerializer.Deserialize<List<Customer>>(data, options);
            var listPage = list.ToPagedList(page ?? 1, 7);
            return View(listPage);

        }
        //add customer
        public IActionResult AddCustomerAccount()
        {
            ViewBag.Name = HttpContext.Session.GetString("GymOwnerName");
            // TODO: Your code here
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddCustomerAccount(Customer obj)
        {
            ViewBag.Name = HttpContext.Session.GetString("GymOwnerName");
            if (ModelState.IsValid)
            {
                string data = JsonSerializer.Serialize(obj);
                var content = new StringContent(data, System.Text.Encoding.UTF8, "application/json");
                HttpResponseMessage response = await client.PostAsync(api_Customer, content);
                if (response.StatusCode == System.Net.HttpStatusCode.Created)
                {
                    TempData["SuccessMessage"] = "Customer account added successfully!";
                    return RedirectToAction("CustomerAccount");
                }
            }
            return View(obj);
        }


        //update customer
        public async Task<IActionResult> UpdateCustomerAccount(int id)
        {
            ViewBag.Name = HttpContext.Session.GetString("GymOwnerName");
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
        public async Task<IActionResult> UpdateCustomerAccount(int id, Customer obj)
        {
            ViewBag.Name = HttpContext.Session.GetString("GymOwnerName");
            api_CustomerById = $"https://localhost:5002/api/Customer/id?id={id}";
            obj.CustomerID = id;
            string data = JsonSerializer.Serialize(obj);
            var content = new StringContent(data, System.Text.Encoding.UTF8, "application/json");
            HttpResponseMessage response = await client.PutAsync(api_CustomerById, content);
            if (response.IsSuccessStatusCode)
            {
                TempData["SuccessMessage"] = "The customer account has been updated successfully!";
                return RedirectToAction("CustomerAccount");
            }
            return Redirect("UpdateCustomerAccount");
        }

        //method delete customer
        public async Task<IActionResult> DeleteCustomerAccount(int id)
        {
            ViewBag.Name = HttpContext.Session.GetString("GymOwnerName");
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
        public async Task<ActionResult> DeleteCustomerAccount(int id, Customer obj)
        {
            ViewBag.Name = HttpContext.Session.GetString("GymOwnerName");
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
                    TempData["SuccessMessage"] = "The customer account has been successfully deleted!";
                    // Xử lý kết quả nếu xóa thành công, ví dụ chuyển hướng đến trang danh sách
                    return RedirectToAction("CustomerAccount");

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

        public async Task<IActionResult> PersonalTrainer(int? page)
        {
            ViewBag.Name = HttpContext.Session.GetString("GymOwnerName");
            if (!checkLogin())
            {
                return Redirect("/GymOwner/Index");
            }
            HttpResponseMessage response = await client.GetAsync(api_PersonalTrainer);
            string data = await response.Content.ReadAsStringAsync();
            var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            List<PersonalTrainer> list = JsonSerializer.Deserialize<List<PersonalTrainer>>(data, options);
            var listPage = list.ToPagedList(page ?? 1, 7);
            return View(listPage);

        }
        //method acc pt accout
        public IActionResult AddPtAccount()
        {
            ViewBag.Name = HttpContext.Session.GetString("GymOwnerName");
            // TODO: Your code here
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddPtAccount(PersonalTrainer obj)
        {
            ViewBag.Name = HttpContext.Session.GetString("GymOwnerName");
            if (ModelState.IsValid)
            {
                string data = JsonSerializer.Serialize(obj);
                var content = new StringContent(data, System.Text.Encoding.UTF8, "application/json");
                HttpResponseMessage response = await client.PostAsync(api_PersonalTrainer, content);
                if (response.StatusCode == System.Net.HttpStatusCode.Created)
                {
                    TempData["SuccessMessage"] = "PT account added successfully!";
                    return RedirectToAction("PersonalTrainer");
                }
            }
            return View(obj);
        }
        //method update pt accout
        public async Task<IActionResult> UpdatePtAccount(int id)
        {
            ViewBag.Name = HttpContext.Session.GetString("GymOwnerName");
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
        public async Task<IActionResult> UpdatePtAccount(int id, PersonalTrainer obj)
        {
            ViewBag.Name = HttpContext.Session.GetString("GymOwnerName");
            api_PersonalTrainerById = $"https://localhost:5002/api/PT/id?id={id}";
            obj.PTID = id;
            string data = JsonSerializer.Serialize(obj);
            var content = new StringContent(data, System.Text.Encoding.UTF8, "application/json");
            HttpResponseMessage response = await client.PutAsync(api_PersonalTrainerById, content);
            if (response.IsSuccessStatusCode)
            {
                TempData["SuccessMessage"] = "The PT account has been updated successfully!";
                return RedirectToAction("PersonalTrainer");
            }
            return Redirect("UpdatePtAccount");
        }
        //method delete Pt accout
        public async Task<IActionResult> DeletePtAccount(int id)
        {
            ViewBag.Name = HttpContext.Session.GetString("GymOwnerName");
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
        public async Task<ActionResult> DeletePtAccount(int id, PersonalTrainer obj)
        {
            ViewBag.Name = HttpContext.Session.GetString("GymOwnerName");
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
                    TempData["SuccessMessage"] = "The PT account has been successfully deleted!";
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
        public async Task<IActionResult> Post(int? page)
        {
            ViewBag.Name = HttpContext.Session.GetString("GymOwnerName");
            if (!checkLogin())
            {
                return Redirect("/GymOwner/Index");
            }
            HttpResponseMessage response = await client.GetAsync(api_Post);
            string data = await response.Content.ReadAsStringAsync();
            var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            List<Post> list = JsonSerializer.Deserialize<List<Post>>(data, options);
            var listPage = list.ToPagedList(page ?? 1, 3);
            return View(listPage);

        }
        //method acc pt accout
        public async Task<IActionResult> AddPost()
        {
            ViewBag.Name = HttpContext.Session.GetString("GymOwnerName");
            ViewBag.NamePT = await GetPtId();
            ViewBag.NameStaff = await GetStaffId();
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddPost(Post obj)
        {
            ViewBag.NamePT = await GetPtId();
            ViewBag.NameStaff = await GetStaffId();

            if (ModelState.IsValid)
            {
                if (obj.ImageUpload != null)
                {
                    string fileName = Path.GetFileNameWithoutExtension(obj.ImageUpload.FileName) + Path.GetExtension(obj.ImageUpload.FileName);
                    string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images/Product", fileName);
                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        await obj.ImageUpload.CopyToAsync(stream);
                    }
                    obj.Image = "/images/Product/" + fileName;
                }
                string data = JsonSerializer.Serialize(obj);
                var content = new StringContent(data, System.Text.Encoding.UTF8, "application/json");
                HttpResponseMessage response = await client.PostAsync(api_Post, content);
                if (response.StatusCode == System.Net.HttpStatusCode.Created)
                {
                    TempData["SuccessMessage"] = "Post added successfully!";
                    return RedirectToAction("Post");
                }
            }
            return View(obj);
        }
        //method update pt accout
        public async Task<IActionResult> UpdatePost(int id)
        {
            ViewBag.Name = HttpContext.Session.GetString("GymOwnerName");
            ViewBag.NamePT = await GetPtId();
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
            if (obj.ImageUpload != null)
            {
                string fileName = Path.GetFileNameWithoutExtension(obj.ImageUpload.FileName) + Path.GetExtension(obj.ImageUpload.FileName);
                string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images/Product", fileName);
                using (var stream = new FileStream(path, FileMode.Create))
                {
                    await obj.ImageUpload.CopyToAsync(stream);
                }
                obj.Image = "/images/Product/" + fileName;
            }
            ViewBag.NamePT = await GetPtId();
            ViewBag.NameStaff = await GetStaffId();
            api_Post = $"https://localhost:5002/api/Post/id?id={id}";
            obj.PostID = id;
            string data = JsonSerializer.Serialize(obj);
            var content = new StringContent(data, System.Text.Encoding.UTF8, "application/json");
            HttpResponseMessage response = await client.PutAsync(api_Post, content);
            if (response.IsSuccessStatusCode)
            {
                TempData["SuccessMessage"] = "The post has been successfully updated!";
                return RedirectToAction("Post");
            }
            return View("UpdatePost");
        }

        //method delete Pt accout
        public async Task<IActionResult> DeletePost(int id)
        {
            ViewBag.Name = HttpContext.Session.GetString("GymOwnerName");
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
            ViewBag.Name = HttpContext.Session.GetString("GymOwnerName");
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
                    TempData["SuccessMessage"] = "The post has been successfully deleted!";
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

        // ------------------------Manage Category -------------------------------------\\
        public async Task<IActionResult> Category(int? page)
        {

            if (!checkLogin())
            {
                return Redirect("/GymOwner/Index");
            }
            ViewBag.Name = HttpContext.Session.GetString("GymOwnerName");
            HttpResponseMessage response = await client.GetAsync(apiCategory);
            string data = await response.Content.ReadAsStringAsync();
            var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            List<Category> list = JsonSerializer.Deserialize<List<Category>>(data, options);
            var listPage = list.ToPagedList(page ?? 1, 3);
            return View(listPage);
        }
        public async Task<IActionResult> AddCategory()
        {
            ViewBag.Name = HttpContext.Session.GetString("GymOwnerName");

            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddCategory(Category obj)
        {
            ViewBag.Name = HttpContext.Session.GetString("GymOwnerName");
            ViewBag.CategoryID = await GetSelectItem();
            if (ModelState.IsValid)
            {
                string data = JsonSerializer.Serialize(obj);
                var content = new StringContent(data, System.Text.Encoding.UTF8, "application/json");
                HttpResponseMessage response = await client.PostAsync(apiCategory, content);
                if (response.StatusCode == System.Net.HttpStatusCode.Created)
                {
                    TempData["SuccessMessage"] = "Category added successfully!";
                    return RedirectToAction("Category");
                }
            }
            return View(obj);
        }
        //method update category
        public async Task<IActionResult> UpdateCategory(int id)
        {
            ViewBag.Name = HttpContext.Session.GetString("GymOwnerName");
            apiCategory = $"https://localhost:5002/api/Category/id?id={id}";
            HttpResponseMessage response = await client.GetAsync(apiCategory);
            // Lấy ID của category cần thiết từ danh sách mục select rồi Gán ID của category vào ViewBag


            if (response.IsSuccessStatusCode)
            {
                var data = response.Content.ReadAsStringAsync().Result;
                var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
                var category = JsonSerializer.Deserialize<Category>(data, options);
                return View(category);
            }
            return NotFound();
        }
        [HttpPost]
        public async Task<IActionResult> UpdateCategory(int id, Category obj)
        {
            ViewBag.Name = HttpContext.Session.GetString("GymOwnerName");
            apiCategory_ById = $"https://localhost:5002/api/Category/id?id={id}";
            string data = JsonSerializer.Serialize(obj);
            var content = new StringContent(data, System.Text.Encoding.UTF8, "application/json");
            HttpResponseMessage response = await client.PutAsync(apiCategory_ById, content);
            if (response.IsSuccessStatusCode)
            {
                TempData["SuccessMessage"] = "The category has been updated successfully!";
                return RedirectToAction("Category");
            }
            return Redirect("UpdateCategory");
        }

        //method delete Pt accout
        public async Task<IActionResult> DeleteCategory(int id)
        {
            ViewBag.Name = HttpContext.Session.GetString("GymOwnerName");
            apiCategory_ById = $"https://localhost:5002/api/Category/id?id={id}";
            HttpResponseMessage response = await client.GetAsync(apiCategory_ById);
            if (response.IsSuccessStatusCode)
            {
                var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
                var data = response.Content.ReadAsStringAsync().Result;
                var category = JsonSerializer.Deserialize<Category>(data, options);
                return View(category);
            }
            return NotFound();
        }
        [HttpPost]
        public async Task<ActionResult> DeleteCategory(int id, Category obj)
        {
            ViewBag.Name = HttpContext.Session.GetString("GymOwnerName");
            apiCategory_ById = $"https://localhost:5002/api/Category/id?id={id}";

            try
            {
                // Tạo yêu cầu DeletePT
                obj.CategoryID = id;
                HttpResponseMessage response = await client.DeleteAsync(apiCategory_ById);
                var data = response.Content.ReadAsStringAsync().Result;
                var category = JsonSerializer.Deserialize<Category>(data);
                // Kiểm tra kết quả trả về từ endpoint API
                if (response.IsSuccessStatusCode)
                {
                    TempData["SuccessMessage"] = "The product has been deleted successfully!";
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
        // ------------------------------------Member Manage --------------------------------\\
        public async Task<IActionResult> MemberAccount(int? page)
        {

            ViewBag.Name = HttpContext.Session.GetString("GymOwnerName");
            if (!checkLogin())
            {
                return Redirect("/GymOwner/Index");
            }
            HttpResponseMessage response = await client.GetAsync(api_Member);
            string data = await response.Content.ReadAsStringAsync();
            var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            List<Member> list = JsonSerializer.Deserialize<List<Member>>(data, options);
            var listPage = list.ToPagedList(page ?? 1, 7);
            return View(listPage);

        }
        //method add member
        public async Task<IActionResult> AddMember()
        {
            ViewBag.Name = HttpContext.Session.GetString("GymOwnerName");
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddMember(Member obj)
        {
            ViewBag.Name = HttpContext.Session.GetString("GymOwnerName");
            if (ModelState.IsValid)
            {
                string data = JsonSerializer.Serialize(obj);
                var content = new StringContent(data, System.Text.Encoding.UTF8, "application/json");
                HttpResponseMessage response = await client.PostAsync(api_Post, content);
                if (response.StatusCode == System.Net.HttpStatusCode.Created)
                {
                    TempData["SuccessMessage"] = "Member added successfully!";
                    return RedirectToAction("MemberAccount");
                }
            }
            return View(obj);
        }

        //method delete Pt member
        public async Task<IActionResult> DeleteMember(int id)
        {

            ViewBag.Name = HttpContext.Session.GetString("GymOwnerName");
            api_MemberById = $"https://localhost:5002/api/Member/id?id={id}";
            HttpResponseMessage response = await client.GetAsync(api_MemberById);
            if (response.IsSuccessStatusCode)
            {
                var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
                var data = response.Content.ReadAsStringAsync().Result;
                var member = JsonSerializer.Deserialize<Member>(data, options);
                return View(member);
            }
            return NotFound();
        }
        [HttpPost]
        public async Task<ActionResult> DeleteMember(int id, Member obj)
        {
            ViewBag.Name = HttpContext.Session.GetString("GymOwnerName");
            api_MemberById = $"https://localhost:5002/api/Member/id?id={id}";

            try
            {
                // Tạo yêu cầu DeletePT
                obj.MemberID = id;
                HttpResponseMessage response = await client.DeleteAsync(api_MemberById);
                var data = response.Content.ReadAsStringAsync().Result;
                var member = JsonSerializer.Deserialize<Member>(data);
                // Kiểm tra kết quả trả về từ endpoint API
                if (response.IsSuccessStatusCode)
                {
                    TempData["SuccessMessage"] = "The member has been successfully deleted!";
                    // Xử lý kết quả nếu xóa thành công, ví dụ chuyển hướng đến trang danh sách
                    return RedirectToAction("MemberAccount");

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

        //method update Status Member
        public async Task<IActionResult> UpdateMember(int id)
        {
            ViewBag.CustomerId = await GetCustomerId();
            ViewBag.MemberId = id;
            ViewBag.Name = HttpContext.Session.GetString("GymOwnerName");
            api_MemberById = $"https://localhost:5002/api/Member/id?id={id}";
            HttpResponseMessage response = await client.GetAsync(api_MemberById);

            if (response.IsSuccessStatusCode)
            {
                var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
                var data = response.Content.ReadAsStringAsync().Result;
                var member = JsonSerializer.Deserialize<Member>(data, options);
                return View(member);
            }
            return NotFound();
        }
        [HttpPost]
        public async Task<IActionResult> UpdateMember(int id, Member obj)
        {


            ViewBag.Name = HttpContext.Session.GetString("GymOwnerName");
            api_MemberById = $"https://localhost:5002/api/Member/id?id={id}";
            obj.MemberID = id;
            ViewBag.CustomerId = await GetCustomerId();
            ViewBag.MemberId = id;
            string data = JsonSerializer.Serialize(obj);
            var content = new StringContent(data, System.Text.Encoding.UTF8, "application/json");
            HttpResponseMessage response = await client.PutAsync(api_MemberById, content);
            if (response.IsSuccessStatusCode)
            {
                TempData["SuccessMessage"] = "The member has been successfully updated!";
                return RedirectToAction("MemberAccount");
            }
            return View("UpdateMember");
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
        //method get pt Id
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
        // method get Staff id
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

        public async Task<List<SelectListItem>> GetCustomerId()
        {
            HttpResponseMessage respone = await client.GetAsync(api_Customer);
            string data = await respone.Content.ReadAsStringAsync();
            var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            List<Customer> list = JsonSerializer.Deserialize<List<Customer>>(data, options);
            List<SelectListItem> yourData = list.Select(c => new SelectListItem
            {
                Value = c.CustomerID.ToString(), // ID của category là giá trị của mục
                Text = c.Name                                // Tên của category là nội dung của mục
            }).ToList();
            return yourData;
        }

        //method check session
        public bool checkLogin()
        {
            var email = HttpContext.Session.GetString("UsernameGymOwner");
            var pass = HttpContext.Session.GetString("PasswordGymOwner");
            if (email != null && pass != null)
            {
                return true;
            }
            return false;
        }

    }
}