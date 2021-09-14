using Coladel.GerenciadorPedidos.Domain.Entidades;
using Coladel.GerenciadorPedidos.Domain.Filters;
using Coladel.GerenciadorPedidos.Domain.Interface;
using Coladel.GerenciadorPedidos.Infra.Data;
using Coladel.GerenciadorPedidos.Infra.Repository.QueryExtensions;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Coladel.GerenciadorPedidos.Infra.Repository
{
    public class PedidoRepository : Repository<Pedido>, IPedidoRepository
    {
        public PedidoRepository(ApplicationDbContext context) : base(context) { }

        public IQueryable<Pedido> BuscarPedidosPorFiltro(BuscarPedidosFiltroFilter filter)
        {
            var retorno = Set.FiltrarPorNomeCliente(filter.Cliente).Include(s => s.Cliente).Include("ItensPedido.Produto");
            return retorno;
        }
    }
}
