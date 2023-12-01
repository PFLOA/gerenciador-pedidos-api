using A4S.ERP.Domain.Entidades;
using A4S.ERP.Domain.Interface;
using A4S.ERP.Infra.Data;
using System.Collections.Generic;
using System.Linq;

namespace A4S.ERP.Infra.Repository
{
    public class CondicoesPagamentoRepository : RepositoryBase<CondicoesPagamento>, ICondicoesPagamentoRepository
    {
        public CondicoesPagamentoRepository(AppDbContext dbContext) : base(dbContext) { }

        public IList<CondicoesPagamento> BuscarCondicoesPagamento()
        {
            return Set.ToList();
        }
    }
}
