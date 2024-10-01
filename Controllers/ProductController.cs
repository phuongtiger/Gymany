using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Gymany.Models;
using Microsoft.AspNetCore.Http;
using X.PagedList;
using Gymany.Core.Service;
using Gymany.Core.Constant;

namespace Gymany.Controllers
{
    /// <summary>
    /// Controller for managing products.
    /// </summary>
    public class ProductController : Controller
    {
        private readonly ApiService _apiService;

        /// <summary>
        /// Initializes a new instance of the <see cref="ProductController"/> class.
        /// </summary>
        /// <param name="apiService">The API service used to make requests.</param>
        public ProductController(ApiService apiService)
        {
            _apiService = apiService;
        }

        /// <summary>
        /// Gets the list of products.
        /// </summary>
        /// <returns>A task representing the asynchronous operation, with a result of the list of products.</returns>
        public async Task<List<Product>> GetProduct()
        {
            // Fetch the list of products from the API.
            List<Product> products = await _apiService.GetAsync<List<Product>>(ApiEndpoints.PRODUCT);
            return products;
        }

        /// <summary>
        /// Displays the list of products with pagination.
        /// </summary>
        /// <param name="page">The page number for pagination.</param>
        /// <returns>An action result representing the view with the list of products.</returns>
        public async Task<ActionResult> Index(int? page)
        {
            // Fetch the list of products.
            List<Product> products = await GetProduct();

            // Retrieve notifications and number of notifications from the session.
            List<Notification> notifications = HttpContext.Session.GetObjectFromJson<List<Notification>>("Notifications");
            string number = HttpContext.Session.GetString("NumberNoti");

            // Fetch the list of categories.
            List<Category> categories = await GetCategory();

            // Paginate the list of products.
            var listpage = products.ToPagedList(page ?? 1, 8);

            // Create the view model.
            var viewModel = new ListModels
            {
                ListProducts = listpage,
                Notifications = notifications,
                NumberNoti = number,
                Categories = categories
            };

            // Return the view with the view model.
            return View(viewModel);
        }

        /// <summary>
        /// Displays the details of a specific product.
        /// </summary>
        /// <param name="id">The ID of the product.</param>
        /// <returns>An action result representing the view with the product details.</returns>
        public async Task<ActionResult> Details(int? id)
        {
            // Fetch the product details from the API.
            Product productnew = await _apiService.GetAsync<Product>(ApiEndpoints.PRODUCT_BY_ID + id);

            // Retrieve notifications and number of notifications from the session.
            List<Notification> notifications = HttpContext.Session.GetObjectFromJson<List<Notification>>("Notifications");
            string number = HttpContext.Session.GetString("NumberNoti");

            // Create the view model.
            var viewModel = new ListModels
            {
                product = productnew,
                Notifications = notifications,
                NumberNoti = number
            };

            // Return the view with the view model.
            return View(viewModel);
        }

        /// <summary>
        /// Gets the list of categories.
        /// </summary>
        /// <returns>A task representing the asynchronous operation, with a result of the list of categories.</returns>
        public async Task<List<Category>> GetCategory()
        {
            // Fetch the list of categories from the API.
            List<Category> list = await _apiService.GetAsync<List<Category>>(ApiEndpoints.CATEGORY);
            return list;
        }

        /// <summary>
        /// Gets the list of categories as select list items.
        /// </summary>
        /// <returns>A task representing the asynchronous operation, with a result of the list of select list items.</returns>
        public async Task<List<SelectListItem>> GetSelectItem()
        {
            // Fetch the list of categories from the API.
            List<Category> listCategory = await _apiService.GetAsync<List<Category>>(ApiEndpoints.CATEGORY);

            // Convert the list of categories to select list items.
            List<SelectListItem> listSelectItem = listCategory.Select(c => new SelectListItem
            {
                Value = c.cate_id.ToString(),
                Text = c.cate_type 
            }).ToList();

            return listSelectItem;
        }
    }
}