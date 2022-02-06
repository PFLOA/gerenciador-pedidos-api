using Coladel.GerenciadorPedidos.Domain.Entidades;
using Coladel.GerenciadorPedidos.Domain.Interface;
using Coladel.GerenciadorPedidos.Infra.Data;

namespace Coladel.GerenciadorPedidos.Infra.Repository
{
    public class ItensPedidoRepository : Repository<ItensPedido>, IItensPedidoRepository
    {
        public ItensPedidoRepository(UserDbContext dbContext) : base(dbContext) { }

    }
}
