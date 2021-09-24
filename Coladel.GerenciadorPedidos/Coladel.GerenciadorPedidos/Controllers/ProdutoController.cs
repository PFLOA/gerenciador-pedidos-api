using Coladel.Application.Handlers.Produtos.Request;
using Coladel.Core;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Coladel.GerenciadorPedidos.Controllers
{
    public class ProdutoController : ApiController
    {
        public ProdutoController(IMediator mediator) : base(mediator) { }

        [HttpGet]
        [AllowAnonymous]
        public Task<IActionResult> BuscarProdutoPorFiltro([FromQuery] BuscarProdutosFiltroRequest request)
        {
            return _mediator.Send(request);
        }

        [HttpGet("Guid/{Guid}")]
        [AllowAnonymous]
        public Task<IActionResult> BuscarProdutoPorGuid([FromRoute] BuscarProdutoPorGuidRequest request)
        {
            return _mediator.Send(request);
        }

        [HttpPost]
        [AllowAnonymous]
        public Task<IActionResult> CriarProduto([FromBody] CriarProdutoRequest request)
        {
            return _mediator.Send(request);
        }

        [HttpPut]
        [AllowAnonymous]
        public Task<IActionResult> AlterarProduto([FromBody] AlterarProdutoRequest request)
        {
            return _mediator.Send(request);
        }

        [HttpPost("ExecutarBackup")]
        [AllowAnonymous]
        public Task<IActionResult> CriarBackupProduto(ExecutarBackupProdutosRequest request)
        {
            return _mediator.Send(request);
        }
    }
}
