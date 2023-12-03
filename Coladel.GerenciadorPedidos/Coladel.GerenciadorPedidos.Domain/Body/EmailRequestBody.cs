using Microsoft.AspNetCore.Http;
using System.Collections.Generic;

namespace A4S.ERP.Domain.Body
{
    public class EmailRequestBody
    {
        public string Body { get; set; }
        public string ToEmail { get; set; }
        public string Subject { get; set; }

        public List<IFormFile> Attachments { get; set; }
    }
}
