using A4S.Application.Handlers.ItemPedido.Request;
using A4S.Application.Handlers.Pedidos.Request;
using A4S.Core;
using A4S.Domain;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace A4S.ERP.Controllers
{
    public class PedidoController : ApiController
    {
        [Autorizacao]
        public PedidoController(IMediator mediator) : base(mediator) { }

        [HttpGet]
        public async Task<IActionResult> BuscarPedidos([FromQuery] BuscarPedidosFiltroRequest request) => await _mediator.Send(request);

        [HttpGet("TotalStatus")]
        public async Task<IActionResult> BuscarTotalStatus([FromQuery] BuscarStatusPedidosRequest request) => await _mediator.Send(request);

        [HttpGet("{Guid}")]
        public async Task<IActionResult> BuscarPedidoPorGuid([FromRoute] BuscarPedidoPorGuidRequest request) => await _mediator.Send(request);

        [HttpPost]
        public async Task<IActionResult> CriarPedido([FromBody] CriarPedidoRequest request) => await _mediator.Send(request);

        [HttpPut("ChangeStatus")]
        public async Task<IActionResult> ChangeStatus([FromBody] ChangeStatusPedidoRequest request) => await _mediator.Send(request);

        [HttpDelete("{Guid}")]
        public async Task<IActionResult> RemoverPedidoPorGuid([FromRoute] RemoverPedidoRequest request) => await _mediator.Send(request);
    }
}
