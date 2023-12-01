using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;

namespace A4S.Application.Handlers.Produtos.Request
{
    public class BuscarProdutoPorGuidRequest : IRequest<IActionResult>
    {
        public Guid Guid { get; set; }
    }
}
