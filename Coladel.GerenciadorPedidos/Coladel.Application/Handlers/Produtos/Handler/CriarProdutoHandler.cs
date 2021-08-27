using Coladel.Application.Handlers.Produtos.Request;
using Coladel.Application.Handlers.Produtos.Response;
using Coladel.GerenciadorPedidos.Domain.Entidades;
using Coladel.GerenciadorPedidos.Domain.Interface;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Coladel.Application.Handlers.Produtos.Handler
{
    public class CriarProdutoHandler : IRequestHandler<CriarProdutoRequest, IActionResult>
    {
        private readonly IProdutoRepository _produtoRepository;

        public CriarProdutoHandler(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }
        public async Task<IActionResult> Handle(CriarProdutoRequest request, CancellationToken cancellationToken)
        {
            try
            {
                Produto produto = _produtoRepository.Criar(request.ToModel());
                return await Task.FromResult(new OkObjectResult(new { Produto = new CriarProdutoResponse(produto) }));
            }
            catch (Exception ex)
            {
                return await Task.FromResult(new BadRequestObjectResult(new { Errors = new[] { $"{ex.Message}" } }));
            }
        }
    }
}
