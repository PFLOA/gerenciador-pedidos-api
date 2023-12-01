using A4S.ERP.Domain.Entidades;
using A4S.Core;
using A4S.ERP.Domain.Enum;

namespace A4S.ERP.Domain.Interface
{
    public interface IEnvioEmailRepository : IRepository<EnvioEmail>
    {
        EnvioEmail BuscarPorTipoEmail(TipoEmail tipoEmail);
    }
}
