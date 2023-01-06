using Coladel.GerenciadorAulas.Domain.Entidades;
using Coladel.GerenciadorAulas.Domain.Enum;
using Coladel.GerenciadorAulas.Domain.Interface;
using Coladel.GerenciadorPedidos.Infra.Data;
using System.Linq;

namespace Coladel.Infra.Repository
{
    internal class EnvioEmailRepository : Repository<EnvioEmail>, IEnvioEmailRepository
    {
        public EnvioEmailRepository(UserDbContext dbContext) : base(dbContext) { }

        public EnvioEmail BuscarPorTipoEmail(TipoEmail tipoEmail) => Set.FirstOrDefault(p => p.TipoEmail == tipoEmail);
    }
}
