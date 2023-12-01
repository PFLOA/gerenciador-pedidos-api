using A4S.ERP.Domain.Body;
using A4S.ERP.Domain.Entidades;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace A4S.Application.Handlers.Produtos.Request
{
    public class CriarProdutoRequest : CriarProdutoRequestBody, IRequest<IActionResult>
    {
        
    }
}
