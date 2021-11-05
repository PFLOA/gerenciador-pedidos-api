using Coladel.Application.Handlers.Produtos.Request;
using Coladel.Core;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Coladel.GerenciadorPedidos.Controllers
{
    public class ProdutoController : ApiController
    {
        public ProdutoController(IMediator mediator) : base(mediator) { }

        [HttpGet]
        public Task<IActionResult> BuscarProdutoPorFiltro([FromQuery] BuscarProdutosFiltroRequest request)
        {
            var user = User.Identity.Name;
            return _mediator.Send(request);
        }

        [HttpGet("Guid/{Guid}")]
        public Task<IActionResult> BuscarProdutoPorGuid([FromRoute] BuscarProdutoPorGuidRequest request)
        {
            return _mediator.Send(request);
        }

        [HttpPost]
        public Task<IActionResult> CriarProduto([FromBody] CriarProdutoRequest request)
        {
            return _mediator.Send(request);
        }

        [HttpPut]
        public Task<IActionResult> AlterarProduto([FromBody] AlterarProdutoRequest request)
        {
            return _mediator.Send(request);
        }

        [HttpPost("ExecutarBackup")]
        public Task<IActionResult> CriarBackupProduto(ExecutarBackupProdutosRequest request)
        {
            return _mediator.Send(request);
        }
    }
}
