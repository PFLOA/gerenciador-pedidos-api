using Coladel.GerenciadorPedidos.Domain.Entidades;
using Coladel.GerenciadorPedidos.Domain.Filters;
using Coladel.GerenciadorPedidos.Domain.Interface;
using Coladel.GerenciadorPedidos.Infra.Data;
using Coladel.GerenciadorPedidos.Infra.Repository.QueryExtensions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace Coladel.GerenciadorPedidos.Infra.Repository
{
    public class ClienteRepository : Repository<Cliente>, IClienteRepository
    {
        public ClienteRepository(UserDbContext dbContext) : base(dbContext) { }

        public IQueryable<Cliente> BuscarClientesPorFiltro(BuscarClientesFiltroFilter filter)
        {
            return Set.Include(p => p.Emails).FiltrarPorNomeCliente(filter.NomeCliente)
                    .FiltrarPorDataCadastro(filter.DataCadastro);
        }

        public override Cliente BuscarPorGuid(Guid guid)
        {
            var result = Set.Include(p => p.Emails).First(p => p.Guid == guid);
            return result;
        }
    }
}
