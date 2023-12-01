using A4S.Core;
using A4S.Domain;
using A4S.ERP.Application.Handlers.NotasFiscais.Request;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace A4S.ERP.Controllers
{
    [Autorizacao]
    public class NotaFiscalController : ApiController
    {
        public NotaFiscalController(IMediator mediator) : base(mediator) { }

        [HttpGet]
        public async Task<IActionResult> BuscarPedidos([FromQuery] BuscarNotasFiscaisFiltroRequest request) => await _mediator.Send(request);

    }
}
