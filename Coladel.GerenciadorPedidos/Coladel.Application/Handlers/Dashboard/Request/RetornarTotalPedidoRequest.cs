using A4S.ERP.Domain.Enum;
using Microsoft.AspNetCore.Mvc;
using MediatR;

namespace A4S.Application.Handlers.Dashboard.Request
{
    public class RetornarTotalPedidoRequest : IRequest<IActionResult>
    {
        public int Dia { get; set; }
        public int Mes { get; set; }
        public int Ano { get; set; }
        public StatusPedido StatusPedido { get; set; }
    }
}
