// using System;
// using System.Collections.Generic;
// using System.Diagnostics;
// using System.Linq;
// using System.Net.Http;
// using System.Net.Http.Headers;
// using System.Text.Json;
// using System.Threading.Tasks;
// using Microsoft.AspNetCore.Mvc;
// using Microsoft.Extensions.Logging;

// namespace Gymany.Areas.Product
// {
//     [Route("[controller]")]
//     public class ProductController : Controller
//     {
//         private string api;

//         private readonly HttpClient client = null;
        
//         public ProductController(){
//             client = new HttpClient();
//             var contentType = new MediaTypeWithQualityHeaderValue("application/json");
//             client.DefaultRequestHeaders.Accept.Add(contentType);
//             this.api = "https://localhost:5001/api/Product";
//         }  

//         public async Task<IActionResult> Index(){
//             HttpResponseMessage response = await client.GetAsync(api);
//             string data = await response.Content.ReadAsStringAsync();

//             var options = new JsonSerializerOptions{PropertyNameCaseInsensitive = true};

//             List<Product> list = JsonSerializer.Deserialize<List<Product>>(data, options);
//             return View(list);
//         }

        

//         public IActionResult Create()
//         {
//             return View();
//         }

//         [HttpPost]
//          public async Task<IActionResult> Create(int id, Product obj){
//             if(ModelState.IsValid)
//             {
//                 string data=JsonSerializer.Serialize(obj);
//                 var content= new StringContent(data, System.Text.Encoding.UTF8, "application/json");
//                 HttpResponseMessage response = await client.PostAsync(api, content);
//                 if (response.StatusCode == System.Net.HttpStatusCode.Created)
//                 return RedirectToAction("Index");
//             }
//             return View(obj);
//          }


//     }
// }