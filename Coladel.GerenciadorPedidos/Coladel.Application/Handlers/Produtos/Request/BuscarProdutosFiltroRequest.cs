using Coladel.GerenciadorPedidos.Domain.Filters;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Coladel.Application.Handlers.Produtos.Request
{
    public class BuscarProdutosFiltroRequest : BuscarProdutosFiltroFilter, IRequest<IActionResult>
    {
    }
}
