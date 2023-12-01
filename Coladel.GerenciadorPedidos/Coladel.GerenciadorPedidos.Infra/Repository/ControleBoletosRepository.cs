using A4S.ERP.Domain.Entidades;
using A4S.ERP.Domain.Interface;
using A4S.ERP.Infra.Data;
using System.Linq;

namespace A4S.ERP.Infra.Repository
{
    public class ControleBoletosRepository : RepositoryBase<ControleBoletos>, IControleBoletosRepository
    {
        public ControleBoletosRepository(AppDbContext dbContext) : base(dbContext) { }

        public ControleBoletos BuscarControleBoletos()
        {
            return Set.FirstOrDefault();
        }
    }
}
