using A4S.ERP.Domain.Entidades;
using A4S.ERP.Domain.Interface;
using A4S.ERP.Infra.Data;

namespace Coladel.GerenciadorPedidos.Infra.Repository
{
    public class ItensPedidoRepository : RepositoryBase<ItensPedido>, IItensPedidoRepository
    {
        public ItensPedidoRepository(AppDbContext dbContext) : base(dbContext) { }

    }
}
