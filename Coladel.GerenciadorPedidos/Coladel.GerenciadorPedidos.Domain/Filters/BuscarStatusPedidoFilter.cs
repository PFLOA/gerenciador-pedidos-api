using Coladel.GerenciadorPedidos.Domain.Enum;

namespace Coladel.GerenciadorPedidos.Domain.Filters
{
    public class BuscarStatusPedidoFilter
    {
        public int Mes { get; set; }
        public int Ano { get; set; }
        public StatusPedido StatusPedido { get; set; }
    }
}
