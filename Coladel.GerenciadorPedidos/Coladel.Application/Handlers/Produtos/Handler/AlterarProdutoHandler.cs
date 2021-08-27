using Coladel.Application.Handlers.Produtos.Request;
using Coladel.Core.Extensions;
using Coladel.GerenciadorPedidos.Domain.Entidades;
using Coladel.GerenciadorPedidos.Domain.Interface;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Coladel.Application.Handlers.Produtos.Handler
{
    public class AlterarProdutoHandler : IRequestHandler<AlterarProdutoRequest, IActionResult>
    {
        private readonly IProdutoRepository _produtoRepository;

        public AlterarProdutoHandler(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }
        public async Task<IActionResult> Handle(AlterarProdutoRequest request, CancellationToken cancellationToken)
        {
            try
            {
                Produto produto = _produtoRepository.BuscarPorGuid(request.Guid);

                if(produto is null) return await Task.FromResult(new NotFoundObjectResult(new { error = "Produto não existe!" }));

                request.MappingDifferenceProperties(produto);
                _produtoRepository.Alterar(produto);

                return await Task.FromResult(new OkObjectResult(new {  guid = request.Guid }));
            }
            catch (Exception ex)
            {
                return await Task.FromResult(new BadRequestObjectResult( new { error = ex.Message}));
            }
        }
    }
}
