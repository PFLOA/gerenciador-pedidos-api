using Coladel.Core;
using MediatR;

namespace Coladel.GerenciadorPedidos.Controllers
{
    public class ClienteController : ApiControllerBase
    {
        public ClienteController(IMediator mediator) : base(mediator) { }
    }
}
