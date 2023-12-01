using A4S.Application.Handlers.Produtos.Request;
using A4S.ERP.Application.Handlers.Produtos.Response;
using A4S.ERP.Domain.Entidades;
using A4S.ERP.Domain.Interface;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace A4S.Application.Handlers.Produtos.Handler
{
    public class BuscarProdutoPorGuidHandler : IRequestHandler<BuscarProdutoPorGuidRequest, IActionResult>
    {
        private readonly IProdutoRepository _produtoRepository;

        public BuscarProdutoPorGuidHandler(IProdutoRepository produtoRepository) => _produtoRepository = produtoRepository;
        public async Task<IActionResult> Handle(BuscarProdutoPorGuidRequest request, CancellationToken cancellationToken)
        {
            try
            {
                Produto produto = _produtoRepository.BuscarPorGuid(request.Guid);

                if (produto is null) return await Task.FromResult(new NotFoundResult());
                return await Task.FromResult(new OkObjectResult(new { OkResult = new BuscarProdutoPorGuidResponse(produto) }));
            }
            catch (Exception ex)
            {
                return await Task.FromResult(new BadRequestObjectResult(new { Errors = new[] { $"{ex.Message}" } }));
            }
        }
    }
}
