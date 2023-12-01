using A4S.Application.Handlers.Empresas.Request;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using A4S.Core;
using MediatR;

namespace A4S.ERP.Controllers
{
    public class EmailController : ApiController
    {
        public EmailController(IMediator mediator) : base(mediator) { }

        [HttpPost]
        public async Task<IActionResult> EnviarEmail([FromForm] EnviarEmailRequest request) => await _mediator.Send(request);

        [HttpPost("NovoEmail")]
        public async Task<IActionResult> NovoEmail([FromBody] GravarNovoEmailRequest request) => await _mediator.Send(request);
    }
}
