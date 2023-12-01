using A4S.Application.Handlers.Produtos.Request;
using A4S.Core;
using A4S.Domain;
using A4S.ERP.Application.Handlers.Produtos.Request;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace A4S.ERP.Controllers
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

        [HttpPost("Importar")]
        public async Task<IActionResult> Importar([FromForm] ImportarProdutosRequest request) => await _mediator.Send(request);
    }
}
