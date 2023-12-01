using A4S.ERP.Domain.Entidades;
using A4S.ERP.Domain.Interface;
using A4S.ERP.Infra.Data;
using System.Linq;

namespace A4S.ERP.Infra.Repository
{
    public class RemessasRepository : RepositoryBase<Remessas>, IRemessasRepository
    {
        public RemessasRepository(AppDbContext dbContext) : base(dbContext) { }

        public Remessas BuscarRemessaPorIdContasReceber(short id)
        {
            return Set.FirstOrDefault(x => x.ContasReceberId == id);
        }
    }
}
