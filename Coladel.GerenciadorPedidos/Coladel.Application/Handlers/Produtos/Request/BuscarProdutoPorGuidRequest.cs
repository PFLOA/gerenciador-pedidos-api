using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Coladel.Application.Handlers.Produtos.Request
{
    public class BuscarProdutoPorGuidRequest : IRequest<IActionResult>
    {
        public Guid Guid { get; set; }
    }
}
