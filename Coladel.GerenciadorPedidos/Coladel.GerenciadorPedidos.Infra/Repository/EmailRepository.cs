using Coladel.GerenciadorAulas.Domain.Entidades;
using Coladel.GerenciadorAulas.Domain.Interface;
using Coladel.GerenciadorPedidos.Infra.Data;

namespace Coladel.Infra.Repository
{
    public class EmailRepository : Repository<Email>, IEmailRepository
    {
        public EmailRepository(UserDbContext dbContext) : base(dbContext) { }
    }
}
