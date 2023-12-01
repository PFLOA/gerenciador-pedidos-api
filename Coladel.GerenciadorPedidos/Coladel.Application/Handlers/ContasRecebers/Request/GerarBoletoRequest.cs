using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;

namespace A4S.ERP.Application.Handlers.ContasRecebers.Request
{
    public class GerarBoletoRequest : IRequest<IActionResult>
    {
        public Guid Guid { get; set; }
    }
}
