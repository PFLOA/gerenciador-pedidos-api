﻿using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;

namespace A4S.Application.Handlers.Pedidos.Request
{
    public class RemoverPedidoRequest : IRequest<IActionResult>
    {
        public Guid Guid { get; set; }
    }
}
