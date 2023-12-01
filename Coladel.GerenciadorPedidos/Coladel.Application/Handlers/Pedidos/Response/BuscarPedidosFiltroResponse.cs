using A4S.ERP.Domain.Entidades;
using A4S.ERP.Domain.Entidades.Response;
using A4S.ERP.Domain.Enum;
using System.Collections.Generic;

namespace A4S.Application.Handlers.Pedidos.Response
{
    public class BuscarPedidosFiltroResponse : PedidoResponse
    {
        public BuscarPedidosFiltroResponse(Pedido pedido) : base(pedido) { }
    }
}
