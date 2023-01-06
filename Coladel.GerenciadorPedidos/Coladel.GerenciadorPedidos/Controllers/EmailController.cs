using Coladel.Application.Handlers.Empresas.Request;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Coladel.Core;
using MediatR;

namespace Coladel.GerenciadorPedidos.Controllers
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
