using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using Gymany.Models;
using Microsoft.AspNetCore.Http;
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
            if (!checkLogin())
            {
                return Redirect("Customer/Form");
            }
            string customerID = HttpContext.Session.GetString("CustomerID");
            int memberid = await GetMemberID(customerID);
            api = $"https://localhost:5002/api/WorkoutPlan/MemberID?memberid={memberid}";
            HttpResponseMessage response = await client.GetAsync(api);
            ListModels listModels = new ListModels();
            if (response.StatusCode == HttpStatusCode.NotFound)
            {
                if(memberid == 0){
                    listModels.CheckMember = false;
                }else{
                    listModels.CheckMember = true;
                }
                return View(listModels);
            }else{
                string data = await response.Content.ReadAsStringAsync();
                var options = new JsonSerializerOptions{PropertyNameCaseInsensitive = true};
                List<WorkoutPlan> workout = JsonSerializer.Deserialize<List<WorkoutPlan>>(data, options);
                listModels = new ListModels{
                    workoutPlans = workout,
                    CheckMember = true
                };
                return View(listModels);
            }
            
        }
        public async Task<int> GetMemberID(string customerID){
            string api = $"https://localhost:5002/api/Member/customerID?CustomerID={customerID}";
            HttpResponseMessage response = await client.GetAsync(api);
            if (response.StatusCode == HttpStatusCode.NotFound){
                return 0;
            }else{
                string data = await response.Content.ReadAsStringAsync();
                var options = new JsonSerializerOptions{PropertyNameCaseInsensitive = true};
                List<Member> member = JsonSerializer.Deserialize<List<Member>>(data, options);
                return member[0].MemberID;
            }
        }
        public bool checkLogin()
        {
            var user = HttpContext.Session.GetString("Username");
            var pass = HttpContext.Session.GetString("Password");
            if (user != null && pass != null)
            {
                return true;
            }
            return false;
        }
    }
}