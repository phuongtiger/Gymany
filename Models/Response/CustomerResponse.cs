using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Gymany.Models.Response
{
    public class CustomerResponse : BaseResponse
    {
        public string token { get; set; }

        public int CustomerID {get; set;}
    }
}