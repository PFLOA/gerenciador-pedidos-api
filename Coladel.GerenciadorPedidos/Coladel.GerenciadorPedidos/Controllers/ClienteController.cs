using A4S.Application.Handlers.Clientes.Request;
using A4S.Core;
using A4S.Domain;
using A4S.ERP.Application.Handlers.Clientes.Request;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace A4S.ERP.Controllers
{
    [Autorizacao]
    public class ClienteController : ApiController
    {
        public ClienteController(IMediator mediator) : base(mediator) { }

        [HttpGet]
        public async Task<IActionResult> BuscarClientesPorFiltro([FromQuery] BuscarClientesFiltroRequest request) => await _mediator.Send(request);

        [HttpGet("{Guid}")]
        public async Task<IActionResult> BuscarClientesPorGuid([FromRoute] BuscarClientePorGuidRequest request) => await _mediator.Send(request);

        [HttpPut]
        public async Task<IActionResult> AlterarCliente([FromBody] AlterarClienteRequest request) => await _mediator.Send(request);

        [HttpPost]
        public async Task<IActionResult> CriarCliente([FromBody] CriarClienteRequest request) => await _mediator.Send(request);

        [HttpDelete]
        public async Task<IActionResult> RemoverCliente([FromBody] RemoverClienteRequest request) => await _mediator.Send(request);

        [HttpPost("Importar")]
        public async Task<IActionResult> Importar([FromForm] ImportarClientesRequest request) => await _mediator.Send(request);

        [HttpPost("Exportar")]
        public async Task<IActionResult> Exportar([FromForm]  ExportarClientes request) => await _mediator.Send(request);
    }
}
