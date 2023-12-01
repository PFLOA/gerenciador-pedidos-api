using A4S.Application.Handlers.Produtos.Request;
using A4S.ERP.Domain.Entidades;
using A4S.ERP.Domain.Interface;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace A4S.Application.Handlers.Produtos.Handler
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
