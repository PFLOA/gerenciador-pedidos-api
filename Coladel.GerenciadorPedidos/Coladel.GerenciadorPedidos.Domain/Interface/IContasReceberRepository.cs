using A4S.Core;
using A4S.ERP.Domain.Entidades;
using System.Linq;

namespace A4S.ERP.Domain.Interface
{
    public interface IContasReceberRepository : IRepository<ContasReceber>
    {

        IQueryable<ContasReceber> BuscarContasReceberPorFiltro();
    }
}
