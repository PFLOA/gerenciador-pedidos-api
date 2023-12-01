using A4S.ERP.Domain.Filters;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace A4S.Application.Handlers.Produtos.Request
{
    public class BuscarProdutosFiltroRequest : BuscarProdutosFiltroFilter, IRequest<IActionResult>
    {
    }
}
