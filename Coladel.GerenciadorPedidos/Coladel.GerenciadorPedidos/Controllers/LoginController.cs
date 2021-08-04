using Coladel.Application.Handlers.Login.Request;
using Coladel.GerenciadorPedidos.Domain.Entidades;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Coladel.GerenciadorPedidos.Controllers
{

    [ApiController]
    [Route("api/v1/[controller]")]
    public class LoginController : ControllerBase
    {
        private readonly IMediator _mediator;
        public LoginController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> Login([FromBody] RealizarLoginRequest login)
        {
            return await _mediator.Send(login);
        }
    }
}
