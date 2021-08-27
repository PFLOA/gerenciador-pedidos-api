using Coladel.Application.Handlers.Clientes.Request;
using Coladel.Core;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Coladel.GerenciadorPedidos.Controllers
{
    public class ClienteController : ApiControllerBase
    {
        public ClienteController(IMediator mediator) : base(mediator) { }

        [HttpGet]
        public Task<IActionResult> BuscarClientesPorFiltro([FromQuery] BuscarClientesFiltroRequest request)
        {
            return _mediator.Send(request);
        }

        [HttpPut]
        public Task<IActionResult> CriarCliente([FromBody] AlterarClienteRequest request)
        {
            return _mediator.Send(request);
        }
        [HttpPost]
        public Task<IActionResult> CriarCliente([FromBody] CriarClienteRequest request)
        {
            return _mediator.Send(request);
        }
    }
}
