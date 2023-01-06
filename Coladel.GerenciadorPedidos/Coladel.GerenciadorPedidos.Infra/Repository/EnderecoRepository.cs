using Coladel.GerenciadorAulas.Domain.Entidades;
using Coladel.GerenciadorAulas.Domain.Interface;
using Coladel.GerenciadorPedidos.Infra.Data;

namespace Coladel.Infra.Repository
{
    public class EnderecoRepository : Repository<Endereco>, IEnderecoRepository
    {
        public EnderecoRepository(UserDbContext dbContext) : base(dbContext) { }
    }
}
