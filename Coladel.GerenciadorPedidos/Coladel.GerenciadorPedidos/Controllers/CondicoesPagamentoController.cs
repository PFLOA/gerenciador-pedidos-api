using A4S.Core;
using A4S.ERP.Application.Handlers.CondicoesPagamentos.Request;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace A4S.ERP.Controllers
{
    public class CondicoesPagamentoController : ApiController
    {
        public CondicoesPagamentoController(IMediator mediator) : base(mediator) { }

        [HttpGet]
        public async Task<IActionResult> RetornarCondicoesPagamento() => await _mediator.Send(new BuscarCondicoesPagamentoRequest());
    }
}
