using A4S.ERP.Domain.Entidades;
using A4S.Core;

namespace A4S.ERP.Domain.Interface
{
    public interface IEmpresaRepository : IRepository<Empresa>
    {
        Empresa RetornarEmpresa();
    }
}
