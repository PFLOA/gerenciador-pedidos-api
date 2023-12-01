using A4S.Core;
using A4S.ERP.Domain.Body;
using A4S.ERP.Domain.Entidades;
using A4S.ERP.Domain.Filters;
using System.Linq;

namespace A4S.ERP.Domain.Interface
{
    public interface IPedidoRepository : IRepository<Pedido>
    {
        IQueryable<Pedido> BuscarPedidosPorFiltro(BuscarPedidosFiltroFilter filter);
        int BuscarTotalStatusPedidosPorFiltro(BuscarStatusPedidoFilter filter);
    }
}
