using Microsoft.AspNetCore.Http;
using System.IO;
using System.Text;

namespace A4S.ERP.Domain.Body
{
    public class EmailRequestBody
    {
        public string Body { get; set; }
        public string ToEmail { get; set; }
        public string Subject { get; set; }
        public string HtmlAnexo { get; set; }
        public string NomeAnexo { get; set; }

        public IFormFile Attachments { get; set; }

    }
}
