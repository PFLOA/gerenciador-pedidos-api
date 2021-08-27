using Coladel.GerenciadorPedidos.Domain.Body;
using Coladel.GerenciadorPedidos.Domain.Entidades;
using Coladel.GerenciadorPedidos.Domain.Filters;
using Coladel.GerenciadorPedidos.Domain.Interface;
using Coladel.GerenciadorPedidos.Infra.Data;
using Coladel.GerenciadorPedidos.Infra.Repository.QueryExtensions;
using System.Linq;

namespace Coladel.GerenciadorPedidos.Infra.Repository
{
    public class ClienteRepository : Repository<Cliente>, IRepository
    {
        public ClienteRepository(ApplicationDbContext dbContext) : base(dbContext) { }

        public IQueryable<Cliente> BuscarClientesPorFiltro(BuscarClientesFiltroFilter filter)
        {
            return Set.FiltrarPorNomeCliente(filter.NomeCliente)
                    .FiltrarPorDataCadastro(filter.DataCadastro);
        }
    }
}
