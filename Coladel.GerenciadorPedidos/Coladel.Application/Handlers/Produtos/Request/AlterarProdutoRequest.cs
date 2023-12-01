using A4S.ERP.Domain.Body;
using A4S.ERP.Domain.Entidades;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;

namespace A4S.Application.Handlers.Produtos.Request
{
    public class AlterarProdutoRequest : CriarProdutoRequestBody, IRequest<IActionResult>
    {
        public Guid Guid { get; set; }
        public override Produto ToModel() => base.ToModel();
    }
}
