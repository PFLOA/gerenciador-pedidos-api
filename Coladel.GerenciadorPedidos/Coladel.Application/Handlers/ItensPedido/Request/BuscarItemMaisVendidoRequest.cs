using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Coladel.Application.Handlers.ItemPedido.Request
{
    public class BuscarItemMaisVendidoRequest : IRequest<IActionResult>
    {
        public int Mes { get; set; }
        public int Ano { get; set; }
    }
}
