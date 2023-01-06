using Coladel.Application.Handlers.Clientes.Request;
using Coladel.Core;
using Coladel.Domain;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Coladel.GerenciadorPedidos.Controllers
{
    [Autorizacao]
    public class ClienteController : ApiController
    {
        public ClienteController(IMediator mediator) : base(mediator) { }

        [HttpGet]
        public async Task<IActionResult> BuscarClientesPorFiltro([FromQuery] BuscarClientesFiltroRequest request) => await _mediator.Send(request);

        [HttpGet("Guid/{Guid}")]
        public async Task<IActionResult> BuscarClientesPorGuid([FromRoute] BuscarClientePorGuidRequest request) => await _mediator.Send(request);

        [HttpPut]
        public async Task<IActionResult> AlterarCliente([FromBody] AlterarClienteRequest request) => await _mediator.Send(request);

        [HttpPost]
        public async Task<IActionResult> CriarCliente([FromBody] CriarClienteRequest request) => await _mediator.Send(request);

        [HttpDelete]
        public async Task<IActionResult> RemoverCliente([FromBody] RemoverClienteRequest request) => await _mediator.Send(request);

        [HttpPost("ExecutarBackup")]
        public async Task<IActionResult> CriarBackupProduto(ExecutarBackupClienteRequest request) => await _mediator.Send(request);
    }
}
