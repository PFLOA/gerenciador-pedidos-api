using A4S.ERP.Application.Handlers.Produtos.Request;
using A4S.ERP.Domain.Interface;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace A4S.ERP.Application.Handlers.Produtos.Handler
{
    public class ImportarProdutoHandler : IRequestHandler<ImportarProdutosRequest, IActionResult>
    {
        private readonly IProdutoRepository _produtoRepository;

        public ImportarProdutoHandler(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        public async Task<IActionResult> Handle(ImportarProdutosRequest request, CancellationToken cancellationToken)
        {
            try
            {
                _produtoRepository.Importar(request.Arquivo.OpenReadStream());

                return await Task.FromResult(new OkObjectResult(new { mensagem = "Importação realizada com sucesso " }));
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
