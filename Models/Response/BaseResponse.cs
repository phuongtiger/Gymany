using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Gymany.Models.Response
{
    public class BaseResponse : HttpResponseMessage
    {
        public string type { get; set; }
        public string tile { get; set; }
        public int status { get; set; }
        public string traceId { get; set; }
    }
}