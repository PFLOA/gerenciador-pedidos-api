using Coladel.GerenciadorAulas.Domain.Entidades;
using Coladel.GerenciadorAulas.Domain.Interface;
using Coladel.GerenciadorPedidos.Infra.Data;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Coladel.Infra.Repository
{
    public class EmpresaRepository : Repository<Empresa>, IEmpresaRepository
    {
        public EmpresaRepository(UserDbContext dbContext) : base(dbContext) { }

        public Empresa RetornarEmpresa()
        {
            return Set.Include(p => p.Configuracoes).Include(p => p.EnvioEmails).FirstOrDefault();
        }
    }
}
