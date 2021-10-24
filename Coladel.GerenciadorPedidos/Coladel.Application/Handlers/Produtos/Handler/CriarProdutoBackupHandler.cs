using Coladel.Application.Handlers.Produtos.Request;
using Coladel.GerenciadorPedidos.Domain.Entidades;
using Coladel.GerenciadorPedidos.Domain.Interface;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Coladel.Application.Handlers.Produtos.Handler
{
    public class CriarProdutoBackupHandler : IRequestHandler<ExecutarBackupProdutosRequest, IActionResult>
    {
        private readonly IProdutoRepository _produtoRepository;

        public CriarProdutoBackupHandler(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        public async Task<IActionResult> Handle(ExecutarBackupProdutosRequest request, CancellationToken cancellationToken)
        {
            try
            {
                return await Task.FromResult(new OkResult());
            }
            catch (Exception ex)
            {
                return await Task.FromResult(new BadRequestObjectResult(new { Errors = new[] { $"{ex.Message}" } }));
            }
        }

        public void CriarProduto(Produto produto)
        {
            _produtoRepository.Criar(produto);
        }
    }
}
