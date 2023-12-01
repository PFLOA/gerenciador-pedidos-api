using A4S.ERP.Domain.Entidades;
using A4S.ERP.Domain.Interface;
using A4S.ERP.Infra.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace A4S.ERP.Infra.Repository
{
    public class ContasReceberRepository : Repository<ContasReceber>, IContasReceberRepository
    {
        public ContasReceberRepository(AppDbContext dbContext) : base(dbContext) { }

        public IQueryable<ContasReceber> BuscarContasReceberPorFiltro()
        {
            return Set.Include(c => c.Cliente).Include(x => x.CondicoesPagamento).OrderBy(x => x.DataVencimento).AsQueryable();
        }

        public override ContasReceber BuscarPorGuid(Guid guid)
        {
            var result = Set
                .Include(c => c.CondicoesPagamento)
                .Include(c => c.Remessas)
                .Include(c => c.Cliente)
                .ThenInclude(c => c.Endereco)
                .First(p => p.Guid == guid);

            return result;
        }
    }
}
