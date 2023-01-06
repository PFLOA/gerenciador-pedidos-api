using Coladel.Application.Handlers.Empresas.Request;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Coladel.Core;
using MediatR;

namespace Coladel.GerenciadorPedidos.Controllers
{
    public class EmpresaController : ApiController
    {
        public EmpresaController(IMediator mediator) : base(mediator) { }

        [HttpGet]
        public async Task<IActionResult> BuscarEmpresa() => await _mediator.Send(new BuscarEmpresaRequest());
    }
}
