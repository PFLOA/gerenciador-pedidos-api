using A4S.Core;
using A4S.ERP.Application.Handlers.ContasRecebers.Request;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace A4S.ERP.Controllers
{
    public class ContasReceberController : ApiController
    {
        public ContasReceberController(IMediator mediator) : base(mediator) { }

        [HttpGet]
        public async Task<IActionResult> BuscarContasReceber([FromQuery] BuscarContasReceberRequest request) => await _mediator.Send(request);

        [HttpPost]
        public async Task<IActionResult> CriarContasReceber([FromBody] CriarContasReceberRequest request) => await _mediator.Send(request);

        [HttpGet("{Guid}")]
        public async Task<IActionResult> BuscarContasReceberPorGuid([FromRoute] BuscarContasReceberPorGuidRequest request) => await _mediator.Send(request);

        [HttpGet("GerarBoleto/{Guid}")]
        public async Task<IActionResult> GerarBoleto([FromRoute] GerarBoletoRequest request) => await _mediator.Send(request);

    }
}
