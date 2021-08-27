using Coladel.GerenciadorPedidos.Domain.Body;
using Coladel.GerenciadorPedidos.Domain.Entidades;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Coladel.Application.Handlers.Produtos.Request
{
    public class AlterarProdutoRequest : CriarProdutoRequestBody, IRequest<IActionResult>
    {
        public Guid Guid { get; set; }
        public override Produto ToModel() => base.ToModel();
    }
}
