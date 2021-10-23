using Coladel.Core.Utils;
using Coladel.GerenciadorPedidos.Domain.Body;
using Coladel.GerenciadorPedidos.Domain.Entidades;
using Coladel.GerenciadorPedidos.Domain.Interface;
using Coladel.GerenciadorPedidos.Infra.Data;
using System.Security.Cryptography;

namespace Coladel.GerenciadorPedidos.Infra.Repository
{
    public class UsuarioRepository : Repository<Usuario>, IUsuarioRepository
    {
        public UsuarioRepository(ApplicationDbContext context) : base(context) { }
        
        public Usuario CriarUsuario(CriarUsuarioRequestBody usuario)
        {
            Hash hash = new Hash(SHA512.Create());

            Usuario usuarioModel = usuario.ToModel();
            usuarioModel.Senha = hash.CriptografarSenha(usuarioModel.Senha, usuarioModel.Guid.ToInt32());
             
            var retorno = Set.Add(usuarioModel);

            context.SaveChanges();

            return retorno.Entity;
        }
    }
}
