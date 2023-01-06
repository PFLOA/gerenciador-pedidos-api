using Coladel.Application.Handlers.Dashboard.Request;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Coladel.Domain;
using Coladel.Core;
using MediatR;

namespace Coladel.GerenciadorPedidos.Controllers
{
    [Autorizacao]
    public class DashboardController : ApiController
    {
        public DashboardController(IMediator mediator) : base(mediator) { }

        [HttpGet("TotalComissao")]
        public async Task<IActionResult> BuscarTotalComissao([FromQuery] RetornarTotalComissaoMesRequest request) => await _mediator.Send(request);

        [HttpGet("TotalPedidos")]
        public async Task<IActionResult> BuscarTotalPedidos([FromQuery] RetornarTotalPedidoRequest request) => await _mediator.Send(request);
    }
}
