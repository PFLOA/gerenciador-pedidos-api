using A4S.ERP.Domain.Entidades;
using A4S.ERP.Domain.Filters;
using A4S.ERP.Domain.Interface;
using A4S.ERP.Infra.Data;
using A4S.ERP.Infra.Repository.QueryExtensions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace A4S.ERP.Infra.Repository
{
    public class ClienteRepository : Repository<Cliente>, IClienteRepository
    {
        public ClienteRepository(AppDbContext dbContext) : base(dbContext) { }

        public IQueryable<Cliente> BuscarClientesPorFiltro(BuscarClientesFiltroFilter filter)
        {
            return Set.FiltrarPorNomeCliente(filter.NomeCliente)
                    .FiltrarPorDataCadastro(filter.DataCadastro);
        }

        public override Cliente BuscarPorGuid(Guid guid)
        {
            var result = Set
                .Include(c => c.CondicoesPagamento)
                .ThenInclude(cp => cp.PlanoContas)
                .Include(c => c.CondicoesPagamento)
                .ThenInclude(cp => cp.MeioPagamento)
                .Include(c => c.CondicoesPagamento)
                .ThenInclude(cp => cp.Parcelas)
                 .Include(c => c.CondicoesPagamento)
                .ThenInclude(cp => cp.ContaDebitar)
                .Include(c => c.Endereco)
                .Include(c => c.EnderecoCobranca)
                .Include(c => c.EnderecoEntrega)
                .Include(c => c.RamoAtividade)
                .Include(c => c.TipoCliente)
                .Include(c => c.ContatosCliente)
                .Include(c => c.ContasReceber)
                .ThenInclude(cr => cr.Remessas)
                .First(p => p.Guid == guid);
            return result;
        }
    }
}
