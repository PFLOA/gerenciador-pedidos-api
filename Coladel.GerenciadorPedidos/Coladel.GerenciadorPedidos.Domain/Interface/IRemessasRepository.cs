using A4S.Core;
using A4S.ERP.Domain.Entidades;

namespace A4S.ERP.Domain.Interface
{
    public interface IRemessasRepository : IRepositoryBase<Remessas>
    {
        Remessas BuscarRemessaPorIdContasReceber(short id);
    }
}
