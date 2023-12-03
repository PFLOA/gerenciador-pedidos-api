using A4S.ERP.Domain.Entidades;
using A4S.ERP.Domain.Enum;
using A4S.ERP.Domain.Interface;
using A4S.ERP.Infra.Data;
using System.Linq;

namespace A4S.ERP.Infra.Repository
{
    internal class EnvioEmailRepository : Repository<EnvioEmail>, IEnvioEmailRepository
    {
        public EnvioEmailRepository(AppDbContext dbContext) : base(dbContext) { }

        public EnvioEmail BuscarPorTipoEmail(TipoEmail tipoEmail) => Set.FirstOrDefault(p => p.TipoEmail == tipoEmail);
    }
}
