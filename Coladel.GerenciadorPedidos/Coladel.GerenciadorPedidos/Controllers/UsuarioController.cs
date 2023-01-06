using Coladel.Application.Handlers.Login.Handler.Usuarios.Request;
using Coladel.Core;
using Coladel.Domain;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Coladel.GerenciadorPedidos.Controllers
{

    public class UsuarioController : ApiController
    {
        public UsuarioController(IMediator mediator): base(mediator) { }

        [HttpPost]
        [Autorizacao]
        public async Task<IActionResult> CriarUsuario([FromBody] CriarUsuarioRequest request) => await _mediator.Send(request);
    }
}
