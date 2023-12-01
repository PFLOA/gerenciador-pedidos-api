using A4S.Core;
using A4S.ERP.Domain.Entidades;
using System.Collections.Generic;

namespace A4S.ERP.Domain.Interface
{
    public interface ICondicoesPagamentoRepository : IRepositoryBase<CondicoesPagamento>
    {
        IList<CondicoesPagamento> BuscarCondicoesPagamento();
    }
}
