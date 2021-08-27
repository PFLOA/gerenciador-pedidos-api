using Coladel.Core;
using Coladel.GerenciadorPedidos.Domain.Body;
using Coladel.GerenciadorPedidos.Domain.Entidades;
using Coladel.GerenciadorPedidos.Domain.Filters;
using System.Linq;

namespace Coladel.GerenciadorPedidos.Domain.Interface
{
    public interface IRepository : IRepository<Cliente>
    {
        IQueryable<Cliente> BuscarClientesPorFiltro(BuscarClientesFiltroFilter filter);
    }
}
