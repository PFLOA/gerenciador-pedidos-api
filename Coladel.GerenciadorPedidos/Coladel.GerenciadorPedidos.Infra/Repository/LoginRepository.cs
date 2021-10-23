using Coladel.Application.Handlers.Login.Request;
using Coladel.Core.Utils;
using Coladel.GerenciadorPedidos.Domain.Entidades;
using Coladel.GerenciadorPedidos.Domain.Interface;
using Coladel.GerenciadorPedidos.Infra.Data;
using System.Linq;
using System.Security.Cryptography;

namespace Coladel.GerenciadorPedidos.Infra.Repository
{
    public class LoginRepository : Repository<Usuario>, ILoginRepository
    {
        public LoginRepository(ApplicationDbContext context) : base(context){ }

        public Usuario LoginUser(string userName, string senha)
        {
            Hash hash = new Hash(SHA512.Create());

            Usuario usuario = Set.FirstOrDefault(p => p.UserName == userName);
            string retorno = hash.VerificarSenha(senha, usuario.Guid.ToInt32());

            if (usuario is null) return null;
            usuario = Set.FirstOrDefault(p => p.UserName == userName && p.Senha == retorno);

            return usuario;
        }
    }
}
