using A4S.Core.Results;
using A4S.ERP.Domain.Entidades;
using A4S.ERP.Domain.Interface;
using A4S.Application.Handlers.Produtos.Request;
using A4S.Application.Handlers.Produtos.Response;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace A4S.Application.Handlers.Produtos.Handler
{
    public class BuscarProdutosFiltroHandler : IRequestHandler<BuscarProdutosFiltroRequest, IActionResult>
    {
        private readonly IProdutoRepository _produtoRepository;

        public BuscarProdutosFiltroHandler(IProdutoRepository produtoRepository) => _produtoRepository = produtoRepository;

        public async Task<IActionResult> Handle(BuscarProdutosFiltroRequest request, CancellationToken cancellationToken)
        {
            Func<Produto, BuscarProdutosFiltroResponse> retorno = Construtor;
            try
            {
                IQueryable<Produto> produtos = _produtoRepository.BuscarProdutosPorFiltro(request);

                return await Task.FromResult(PaginatedResult<BuscarProdutosFiltroResponse>.CreateSuccess(request, produtos, retorno));
            }
            catch (Exception ex)
            {
                return await Task.FromResult(new BadRequestObjectResult(new { Errors = new[] { $"{ex.Message}" } }));
            }
        }

        public BuscarProdutosFiltroResponse Construtor(Produto produto) => new BuscarProdutosFiltroResponse(produto);
    }
}
