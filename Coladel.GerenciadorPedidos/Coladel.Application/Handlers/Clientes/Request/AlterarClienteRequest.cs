using Coladel.GerenciadorPedidos.Domain.Body;
using Coladel.GerenciadorPedidos.Domain.Entidades;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Coladel.Application.Handlers.Clientes.Request
{
    public class AlterarClienteRequest : CriarClienteRequestBody, IRequest<IActionResult>
    {
        public Guid Guid { get; set; }
        public override Cliente ToModel() =>  base.ToModel();  
    }
}
