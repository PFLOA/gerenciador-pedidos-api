using A4S.ERP.Domain.Entidades;
using A4S.ERP.Domain.Interface;
using A4S.ERP.Infra.Data;

namespace A4S.ERP.Infra.Repository
{
    public class NotaFiscalRepository : Repository<NotaFiscal>, INotaFiscalRepository
    {
        public NotaFiscalRepository(AppDbContext dbContext) : base(dbContext) { }
    }
}
