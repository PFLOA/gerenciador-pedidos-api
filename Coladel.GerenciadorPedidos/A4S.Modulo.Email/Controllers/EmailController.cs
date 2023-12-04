using A4S.Core;
using A4S.Core.Rest;
using A4S.ERP.Domain.Body;
using A4S.ERP.Domain.Interface.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;

namespace A4S.Modulo.Email.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class EmailController : RestController
    {
        private readonly ILogger<EmailController> _logger;
        private readonly IMailService _mailService;

        public EmailController(IMailService mailService, ILogger<EmailController> logger)
        {
            _logger = logger;
            _mailService = mailService;
        }

        [HttpPost("Send")]
        public IActionResult EnviarEmail([FromForm] EmailRequestBody request)
        {
            try
            {
                _mailService.SendEmail(request);
                return Ok();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
