using A4S.ERP.Domain.Enum;

namespace A4S.ERP.Domain.Filters
{
    public class BuscarStatusPedidoFilter
    {
        public int Mes { get; set; }
        public int Ano { get; set; }
        public StatusPedido StatusPedido { get; set; }
    }
}
