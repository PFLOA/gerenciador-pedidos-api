using A4S.Application.Handlers.Empresas.Request;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using A4S.Core;
using MediatR;
using A4S.ERP.Application.Handlers.Empresas.Request;

namespace A4S.ERP.Controllers
{
    public class EmpresaController : ApiController
    {
        public EmpresaController(IMediator mediator) : base(mediator) { }

        [HttpGet]
        public async Task<IActionResult> BuscarEmpresa() => await _mediator.Send(new BuscarEmpresaRequest());

        [HttpPost("Certificado")]
        public async Task<IActionResult> CadastrarCertificado([FromForm] CadastrarCertificadoRequest request) => await _mediator.Send(request);
    }
}
