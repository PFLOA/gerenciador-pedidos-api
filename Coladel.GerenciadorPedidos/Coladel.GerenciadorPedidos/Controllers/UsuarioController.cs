using Coladel.Application.Handlers.Login.Handler.Usuarios.Request;
using Coladel.Core;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Coladel.GerenciadorPedidos.Controllers
{

    public class UsuarioController : ApiControllerBase
    {
        public UsuarioController(IMediator mediator): base(mediator) { }

        [HttpPost]
        public Task<IActionResult> CriarUsuario([FromBody] CriarUsuarioRequest request)
        {
            return _mediator.Send(request);
        }
    }
}
