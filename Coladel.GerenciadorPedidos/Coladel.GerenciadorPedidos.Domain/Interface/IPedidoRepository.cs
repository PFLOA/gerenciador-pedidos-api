using Coladel.Core;
using Coladel.GerenciadorPedidos.Domain.Entidades;
using Coladel.GerenciadorPedidos.Domain.Filters;
using System.Linq;

namespace Coladel.GerenciadorPedidos.Domain.Interface
{
    public interface IPedidoRepository : IRepository<Pedido>
    {
        IQueryable<Pedido> BuscarPedidosPorFiltro(BuscarPedidosFiltroFilter filter);
    }
}
