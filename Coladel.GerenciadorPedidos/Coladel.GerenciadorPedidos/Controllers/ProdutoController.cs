using Coladel.Application.Handlers.Produtos.Request;
using Coladel.Core;
using Coladel.Domain;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Coladel.GerenciadorPedidos.Controllers
{
    public class ProdutoController : ApiController
    {
        [Autorizacao]
        public ProdutoController(IMediator mediator) : base(mediator) { }

        [HttpGet]
        public async Task<IActionResult> BuscarProdutoPorFiltro([FromQuery] BuscarProdutosFiltroRequest request) => await _mediator.Send(request);

        [HttpGet("Guid/{Guid}")]
        public async Task<IActionResult> BuscarProdutoPorGuid([FromRoute] BuscarProdutoPorGuidRequest request) => await _mediator.Send(request);

        [HttpPost]
        public async Task<IActionResult> CriarProduto([FromBody] CriarProdutoRequest request) => await _mediator.Send(request);

        [HttpPut]
        public async Task<IActionResult> AlterarProduto([FromBody] AlterarProdutoRequest request) => await _mediator.Send(request);

        [HttpPost("ExecutarBackup")]
        public async Task<IActionResult> CriarBackupProduto(ExecutarBackupProdutosRequest request) => await _mediator.Send(request);
    }
}
