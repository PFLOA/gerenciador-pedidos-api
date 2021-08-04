using Coladel.GerenciadorPedidos.Domain.Body;
using Coladel.GerenciadorPedidos.Domain.Entidades;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Coladel.Application.Handlers.Produtos.Request
{
    public class CriarProdutoRequest : CriarProdutoRequestBody, IRequest<IActionResult>
    {
        
    }
}
