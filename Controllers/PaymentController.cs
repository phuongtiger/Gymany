using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Gymany.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.VisualStudio.Web.CodeGeneration.Utils;
using System.Configuration;
using VNPAY_CS_ASPX.Models;
using Microsoft.AspNetCore.Http;
using System.Net.Http;
using System.Text.Json;
namespace Gymany.Controllers
{
    public class PaymentController : Controller
    {
        private readonly HttpClient client = null;
        private string api_Order;
        public PaymentController(){
            client = new HttpClient();
            api_Order = "https://localhost:5001/api/Order";
        }
        public async Task<List<Order>> GetListOrders(){
            List<int> ListOrder = HttpContext.Session.GetObjectFromJson<List<int>>("listOrderID");
            List<Order> OrderPayment = new List<Order>();
            foreach (var item in ListOrder)
            {   
                api_Order = $"https://localhost:5002/api/Order/id?id={item}";
                HttpResponseMessage respone = await client.GetAsync(api_Order);
                string data = await respone.Content.ReadAsStringAsync();
                var options = new JsonSerializerOptions{PropertyNameCaseInsensitive = true};
                Order Order = JsonSerializer.Deserialize<Order>(data, options);
                OrderPayment.Add(Order);
            }
            return OrderPayment;
        }
        public async Task<IActionResult> Payment()
        {
            List<Order> order = await GetListOrders();
            string vnp_Returnurl = "https://localhost:5001/Payment/Back"; //URL nhan ket qua tra ve
            string locale = "vn";
            int AmountOrder = 0;
            string orderID = "";
            foreach (var item in order)
            {
                AmountOrder += (int)item.Total;
                orderID = item.OrderID.ToString();
            }
            //Build URL for VNPAY
            VnPayLibrary vnpay = new VnPayLibrary();

            vnpay.AddRequestData("vnp_Version", VnPayLibrary.VERSION);
            vnpay.AddRequestData("vnp_Command", "pay");
            vnpay.AddRequestData("vnp_TmnCode", "5YRU8MN1");
            vnpay.AddRequestData("vnp_Amount", (AmountOrder * 100).ToString()); //Số tiền thanh toán. Số tiền không mang các ký tự phân tách thập phân, phần nghìn, ký tự tiền tệ. Để gửi số tiền thanh toán là 100,000 VND (một trăm nghìn VNĐ) thì merchant cần nhân thêm 100 lần (khử phần thập phân), sau đó gửi sang VNPAY là: 10000000
            vnpay.AddRequestData("vnp_BankCode", "");
            vnpay.AddRequestData("vnp_CreateDate", DateTime.Now.ToString("yyyyMMddHHmmss"));
            vnpay.AddRequestData("vnp_CurrCode", "VND");
            vnpay.AddRequestData("vnp_IpAddr", "127.1.1.1");
            vnpay.AddRequestData("vnp_Locale", locale);
            vnpay.AddRequestData("vnp_OrderInfo", "Thanh toan don hang:" + orderID);
            vnpay.AddRequestData("vnp_OrderType", "billpayment"); //default value: other
            vnpay.AddRequestData("vnp_ReturnUrl", vnp_Returnurl);
            vnpay.AddRequestData("vnp_TxnRef", orderID);
            vnpay.AddRequestData("vnp_Bill_Address", "cantho");
            vnpay.AddRequestData("vnp_Bill_City", "CanTho");
            vnpay.AddRequestData("vnp_Bill_Country", "CanTho");
            vnpay.AddRequestData("vnp_Bill_State", "");
            // Invoice
            vnpay.AddRequestData("vnp_Inv_Phone", "0326776754");
            vnpay.AddRequestData("vnp_Inv_Email", "hhphuong465@gmail.com");
            vnpay.AddRequestData("vnp_Inv_Customer", "HoangHuyPhuong");
            vnpay.AddRequestData("vnp_Inv_Address", "CanTho");
            vnpay.AddRequestData("vnp_Inv_Company", "FPT");
            vnpay.AddRequestData("vnp_Inv_Taxcode", "123");
            vnpay.AddRequestData("vnp_Inv_Type", "1");
            string vnp_Url = "http://sandbox.vnpayment.vn/paymentv2/vpcpay.html";
            string vnp_HashSecret = "NNZWLMCAAPXOIAMNYFJRKLYHMHEKFLGB";
            string paymentUrl = vnpay.CreateRequestUrl(vnp_Url, vnp_HashSecret);
            return Redirect(paymentUrl);
        }

        public  async Task<IActionResult> Back()
        {
            List<Order> orders = await GetListOrders();
            string vnp_HashSecret = ""; 
            VnPayLibrary vnpay = new VnPayLibrary();
            string vnp_ResponseCode = Request.Query["vnp_ResponseCode"];
            string vnp_TransactionStatus = Request.Query["vnp_TransactionStatus"];
            string vnp_SecureHash = Request.Query["vnp_SecureHash"];
            bool checkSignature = vnpay.ValidateSignature(vnp_SecureHash, vnp_HashSecret);
            ViewBag.Check = false;
            foreach (var item in orders)
            {
                item.Status = "Failed";
            }
            if (vnp_TransactionStatus.Equals("00") && vnp_ResponseCode.Equals("00"))
            {
                string IsMember = HttpContext.Session.GetString("IsMember");
                if(IsMember == "false"){
                    string customerID = HttpContext.Session.GetString("CustomerID");
                    string apiMember = $"https://localhost:5002/api/Member/customerID?CustomerID={customerID}";
                    HttpResponseMessage responseMember1 = await client.GetAsync(apiMember);
                    string data = await responseMember1.Content.ReadAsStringAsync();
                    var options = new JsonSerializerOptions{PropertyNameCaseInsensitive = true};
                    List<Member> member = JsonSerializer.Deserialize<List<Member>>(data, options);
                    member[0].Status = "Accepted";
                    apiMember = "https://localhost:5002/api/Member/Id";
                    string dataMember = JsonSerializer.Serialize(member[0]);
                    var contentMember = new StringContent(dataMember, System.Text.Encoding.UTF8, "application/json");
                    HttpResponseMessage responseMember2 = await client.PutAsync(apiMember, contentMember);
                    if (responseMember2.StatusCode == System.Net.HttpStatusCode.Created)
                    {
                        HttpContext.Session.SetString("IsMember", "true");
                    }
                }
                int totalPayment = 0;
                Payment payment = new Payment();
                foreach (var order in orders)
                {
                    totalPayment += (int)order.Total;
                    payment = new Payment{
                        CustomerID = order.CustomerID,
                        ProductID = order.ProductID,
                        Quantity = totalPayment,
                        Date = DateTime.Now
                    };
                }
                
                string apiPayment = "https://localhost:5002/api/Payment";
                string dataPayment = JsonSerializer.Serialize(payment);
                var content = new StringContent(dataPayment, System.Text.Encoding.UTF8, "application/json");
                HttpResponseMessage respone = await client.PostAsync(apiPayment, content);
                if (respone.StatusCode == System.Net.HttpStatusCode.Created)
                {
                    foreach (var order in orders)
                    {
                        order.Status = "Success";
                        string dataOrder = JsonSerializer.Serialize(order);
                        var contentOrder = new StringContent(dataOrder, System.Text.Encoding.UTF8, "application/json");
                        HttpResponseMessage response = await client.PutAsync(api_Order, contentOrder);
                        if (response.StatusCode == System.Net.HttpStatusCode.Created)
                        {
                            ViewBag.Check = true;
                        }
                    }
                }
            }
            ListModels list = new ListModels();
            return View(list);
        }
    }
}