using Coladel.GerenciadorPedidos.Domain.Body;
using Coladel.GerenciadorPedidos.Domain.Entidades;
using Coladel.GerenciadorPedidos.Domain.Filters;
using System.Linq;

namespace Coladel.GerenciadorPedidos.Domain.Interface
{
    public interface IClienteRepository
    {
        IQueryable<Cliente> BuscarClientesPorFiltro(BuscarClientesFiltroFilter filter);
        Cliente CriarCliente(CriarClienteRequestBody cliente);
    }
}
