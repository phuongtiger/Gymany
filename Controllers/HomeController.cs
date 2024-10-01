using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Gymany.Models;
using Microsoft.AspNetCore.Http;
using X.PagedList;
using Gymany.Core.Service;
using Gymany.Core.Constant;

namespace Gymany.Controllers
{
    /// <summary>
    /// Controller for managing home-related actions.
    /// </summary>
    public class HomeController : Controller
    {
        private readonly ApiService _apiService;

        /// <summary>
        /// Initializes a new instance of the <see cref="HomeController"/> class.
        /// </summary>
        /// <param name="apiService">The API service used to make requests.</param>
        public HomeController(ApiService apiService)
        {
            _apiService = apiService;
        }

        /// <summary>
        /// Displays the home page with a list of products and other information.
        /// </summary>
        /// <param name="page">The page number for pagination.</param>
        /// <returns>An action result representing the view with the list of products.</returns>
        public async Task<IActionResult> Index(int? page)
        {
            // Log the product endpoint for debugging purposes.
            System.Console.WriteLine(ApiEndpoints.PRODUCT);

            // Fetch the list of products from the API.
            List<Product> products = await _apiService.GetAsync<List<Product>>(ApiEndpoints.PRODUCT);

            // Retrieve notifications and number of notifications from the session.
            List<Notification> notifications = HttpContext.Session.GetObjectFromJson<List<Notification>>("Notifications");
            string number = HttpContext.Session.GetString("NumberNoti");

            // Fetch the list of categories from the API.
            List<Category> categories = await _apiService.GetAsync<List<Category>>(ApiEndpoints.CATEGORY);

            // Paginate the list of products.
            var listpage = products.ToPagedList(page ?? 1, 8);

            // Create the view model.
            var viewModel = new ListModels
            {
                ListProducts = listpage,
                NumberNoti = number,
                Notifications = notifications,
                Categories = categories
            };

            // Return the view with the view model.
            return View(viewModel);
        }

        /// <summary>
        /// Searches for products based on the search content.
        /// </summary>
        /// <param name="SearchContent">The content to search for.</param>
        /// <returns>An action result representing the view with the search results.</returns>
        [HttpPost]
        public async Task<IActionResult> Search(string SearchContent)
        {
            // Fetch the list of products from the API.
            List<Product> products = await _apiService.GetAsync<List<Product>>(ApiEndpoints.PRODUCT);

            // Filter the products based on the search content.
            if (!String.IsNullOrEmpty(SearchContent))
            {
                products = products.Where(s => s.prod_name.ToLower().Contains(SearchContent.ToLower())).ToList();
            }
            else
            {
                return RedirectToAction("Index");
            }

            // Create the view model.
            ListModels listModels = new ListModels
            {
                Products = products,
                NumberNoti = HttpContext.Session.GetString("NumberNoti"),
                Notifications = HttpContext.Session.GetObjectFromJson<List<Notification>>("Notifications"),
                Categories = await _apiService.GetAsync<List<Category>>(ApiEndpoints.CATEGORY)
            };

            // Return the view with the view model.
            return View(listModels);
        }

        /// <summary>
        /// Displays the BMI calculation page.
        /// </summary>
        /// <returns>An action result representing the view for BMI calculation.</returns>
        public IActionResult BMI()
        {
            // Create an empty view model.
            ListModels listModels = new ListModels();

            // Return the view with the view model.
            return View(listModels);
        }
    }
}