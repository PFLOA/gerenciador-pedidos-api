using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace A4S.ERP.Application.Handlers.Produtos.Request
{
    public class ImportarProdutosRequest : IRequest<IActionResult>
    {
        public IFormFile Arquivo { get; set; }
    }
}
