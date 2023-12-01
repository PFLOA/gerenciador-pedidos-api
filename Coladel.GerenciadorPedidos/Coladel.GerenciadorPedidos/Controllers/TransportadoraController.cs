using A4S.Core;
using A4S.Domain;
using A4S.ERP.Application.Handlers.Transportadoras.Request;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace A4S.ERP.Controllers
{
    [Autorizacao]
    public class TransportadoraController : ApiController
    {
        public TransportadoraController(IMediator mediator) : base(mediator) { }

        [HttpGet]
        public async Task<IActionResult> BuscarTransportadoraPorFiltro([FromQuery] BuscarTransportadoraPorFiltroRequest request) => await _mediator.Send(request);

        [HttpPost]
        public async Task<IActionResult> CadastrarTransportadora([FromQuery] CadastrarTransportadoraRequest request) => await _mediator.Send(request);

        [HttpPost("Importar")]
        public async Task<IActionResult> Importar([FromForm] ImportarTransportadoraRequest request) => await _mediator.Send(request);

    }
}
