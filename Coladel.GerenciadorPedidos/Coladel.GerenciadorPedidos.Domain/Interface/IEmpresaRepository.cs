using Coladel.GerenciadorAulas.Domain.Entidades;
using Coladel.Core;

namespace Coladel.GerenciadorAulas.Domain.Interface
{
    public interface IEmpresaRepository : IRepository<Empresa>
    {
        Empresa RetornarEmpresa();
    }
}
