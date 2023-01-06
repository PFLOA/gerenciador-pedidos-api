using Coladel.GerenciadorAulas.Domain.Entidades;
using Coladel.Core;
using Coladel.GerenciadorAulas.Domain.Enum;

namespace Coladel.GerenciadorAulas.Domain.Interface
{
    public interface IEnvioEmailRepository : IRepository<EnvioEmail>
    {
        EnvioEmail BuscarPorTipoEmail(TipoEmail tipoEmail);
    }
}
