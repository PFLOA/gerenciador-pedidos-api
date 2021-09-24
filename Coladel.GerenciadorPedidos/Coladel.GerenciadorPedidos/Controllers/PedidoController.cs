using Coladel.Application.Handlers.Pedidos.Request;
using Coladel.Core;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Coladel.GerenciadorPedidos.Controllers
{
    public class PedidoController : ApiController
    {
        public PedidoController(IMediator mediator) : base(mediator) { }

        [HttpGet]
        [AllowAnonymous]
        public Task<IActionResult> BuscarPedidos([FromQuery] BuscarPedidosFiltroRequest request)
        {
            return _mediator.Send(request);
        }

        [HttpPost]
        [AllowAnonymous]
        public Task<IActionResult> CriarPedido([FromBody] CriarPedidoRequest request)
        {
            return _mediator.Send(request);
        }
    }
}
