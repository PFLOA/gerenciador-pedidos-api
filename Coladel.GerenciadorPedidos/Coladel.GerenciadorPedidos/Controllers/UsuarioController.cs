using A4S.Application.Handlers.Login.Handler.Usuarios.Request;
using A4S.Core;
using A4S.Domain;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace A4S.ERP.Controllers
{

    public class UsuarioController : ApiController
    {
        public UsuarioController(IMediator mediator): base(mediator) { }

        [HttpPost]
        [Autorizacao]
        public async Task<IActionResult> CriarUsuario([FromBody] CriarUsuarioRequest request) => await _mediator.Send(request);
    }
}
