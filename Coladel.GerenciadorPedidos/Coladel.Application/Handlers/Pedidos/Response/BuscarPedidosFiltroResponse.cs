using Coladel.GerenciadorPedidos.Domain.Entidades;
using Coladel.GerenciadorPedidos.Domain.Entidades.Response;
using Coladel.GerenciadorPedidos.Domain.Enum;
using System.Collections.Generic;

namespace Coladel.Application.Handlers.Pedidos.Response
{
    public class BuscarPedidosFiltroResponse : PedidoResponse
    {
        public BuscarPedidosFiltroResponse(Pedido pedido) : base(pedido) { }
    }
}
