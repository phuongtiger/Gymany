using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Gymany.Controllers
{
    public class CartController : Controller
    {

        private readonly HttpClient client = null;
        public IActionResult Index()
        {
            // TODO: Your code here
            return View();
        }


        //   private readonly HttpClient client = null;
        //         private string api;
        //         private string api_ProductByID;
        //         private string apiCategory;
        //         public CartController(){
        //             client = new HttpClient();
        //             var contentType = new MediaTypeWithQualityHeaderValue("application/json");
        //             client.DefaultRequestHeaders.Accept.Add(contentType);
        //             this.api = "https://localhost:5002/api/Product";
        //             this.apiCategory = "https://localhost:5002/api/Category";
        //             this.api_ProductByID = "https://localhost:5002/api/Product/id";
        //         }
        //         public async Task<ActionResult> Index()
        //         {
        //             HttpResponseMessage respone = await client.GetAsync(api);
        //             string data = await respone.Content.ReadAsStringAsync();
        //             var options = new JsonSerializerOptions{PropertyNameCaseInsensitive = true};
        //             List<Product> list = JsonSerializer.Deserialize<List<Product>>(data, options);
        //             return View(list);
        //         }

    }
}