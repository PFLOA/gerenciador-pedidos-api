using Coladel.Core;
using Coladel.GerenciadorPedidos.Domain.Body;
using Coladel.GerenciadorPedidos.Domain.Entidades;
using Coladel.GerenciadorPedidos.Domain.Filters;
using System.Linq;

namespace Coladel.GerenciadorPedidos.Domain.Interface
{
    public interface IPedidoRepository : IRepository<Pedido>
    {
        ProdutoMaisVendidoBody BuscarProdutoMaisVendidoMesAnoDados(int mes, int ano);
        IQueryable<Pedido> BuscarPedidosPorFiltro(BuscarPedidosFiltroFilter filter);
        int BuscarTotalStatusPedidosPorFiltro(BuscarStatusPedidoFilter filter);
    }
}
