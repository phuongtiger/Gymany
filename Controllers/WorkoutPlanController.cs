using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using Gymany.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Gymany.Controllers
{
    public class WorkoutPlanController : Controller
    {
        private readonly HttpClient client = null;
        private string api;
        public WorkoutPlanController()
        {
            client = new HttpClient();
            this.api = "https://localhost:5002/api/WorkoutPlan";
        }
        public async Task<IActionResult> IndexAsync()
        {
            HttpResponseMessage respone = await client.GetAsync(api);
            string data = await respone.Content.ReadAsStringAsync();
            var options = new JsonSerializerOptions{PropertyNameCaseInsensitive = true};
            List<WorkoutPlan> workout = JsonSerializer.Deserialize<List<WorkoutPlan>>(data, options);
            ListModels listModels = new ListModels{
                workoutPlans = workout
            };
            return View(listModels);
        }
    }
}