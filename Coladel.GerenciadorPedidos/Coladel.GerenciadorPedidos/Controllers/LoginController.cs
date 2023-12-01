using A4S.Application.Handlers.Login.Request;
using A4S.Core;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace A4S.ERP.Controllers
{
    [AllowAnonymous]
    public class LoginController : ApiController
    {
        public LoginController(IMediator mediator) : base(mediator) { }

        [HttpPost]
        public async Task<IActionResult> Login([FromBody] RealizarLoginRequest login) => await ExecuteAsync(async () => await _mediator.Send(login));
    }
}
