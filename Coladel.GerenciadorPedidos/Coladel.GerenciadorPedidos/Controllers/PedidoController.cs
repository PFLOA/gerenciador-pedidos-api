using Coladel.Application.Handlers.Pedidos.Request;
using Coladel.Core;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Coladel.GerenciadorPedidos.Controllers
{
    [AllowAnonymous]
    public class PedidoController : ApiController
    {
        public PedidoController(IMediator mediator) : base(mediator) { }

        [HttpGet]
        public async Task<IActionResult> BuscarPedidos([FromQuery] BuscarPedidosFiltroRequest request)
        {
            return await _mediator.Send(request);
        }

        [HttpPost]
        public async Task<IActionResult> CriarPedido([FromBody] CriarPedidoRequest request)
        {
            return await _mediator.Send(request);
        }
    }
}
