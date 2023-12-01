using A4S.Core.Utils;
using A4S.ERP.Domain.Entidades;
using A4S.ERP.Domain.Interface;
using A4S.ERP.Infra.Data;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Security.Cryptography;

namespace A4S.ERP.Infra.Repository
{
    public class LoginRepository : UserRepository<Usuario>, ILoginRepository
    {
        public LoginRepository(UserDbContext context) : base(context) { }

        public Usuario LoginUser(string userName, string senha)
        {
            Hash hash = new Hash(SHA512.Create());

            Usuario usuario = Set.FirstOrDefault(p => p.Email == userName);
            if (usuario is null) return null;

            string retorno = hash.VerificarSenha(senha, usuario.Guid.ToInt32());
            usuario = Set.Include(p => p.Role)
                .Include(p => p.Setor)
                .Include(p => p.Empresa)
                .ThenInclude(p => p.BdEmpresa)
                .FirstOrDefault(p => p.Email == userName && p.Senha == retorno);

            if (usuario is null) return null;

            return usuario;
        }
    }
}
