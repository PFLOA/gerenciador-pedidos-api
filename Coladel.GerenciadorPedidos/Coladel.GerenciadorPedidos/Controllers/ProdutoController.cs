using Coladel.Application.Handlers.Produtos.Request;
using Coladel.Core;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Coladel.GerenciadorPedidos.Controllers
{
    public class ProdutoController : ApiControllerBase
    {
        public ProdutoController(IMediator mediator) : base(mediator) { }

        [HttpPost]
        [AllowAnonymous]
        public Task<IActionResult> CriarProduto([FromBody] CriarProdutoRequest request)
        {
            return _mediator.Send(request);
        }
    }
}
