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

        public IFormFile Attachments { get; set; }

        public string ReadAsList()
        {
            var result = new StringBuilder();

            using (var reader = new StreamReader(Attachments.OpenReadStream()))
            {
                while (reader.Peek() >= 0)
                    result.AppendLine(reader.ReadLine());
            }

            return result.ToString();
        }
    }
}
