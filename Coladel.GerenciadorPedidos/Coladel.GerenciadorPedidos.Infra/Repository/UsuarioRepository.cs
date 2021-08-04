using Coladel.Application.Handlers.Usuarios.Response;
using Coladel.GerenciadorPedidos.Domain.Entidades;
using Coladel.GerenciadorPedidos.Domain.Interface;
using Coladel.GerenciadorPedidos.Infra.Data;

namespace Coladel.GerenciadorPedidos.Infra.Repository
{
    public class UsuarioRepository : Repository<Usuario>, IUsuarioRepository
    {
        public UsuarioRepository(ApplicationDbContext context) : base(context) { }
        
        public Usuario CriarUsuario(Usuario usuario)
        {
            CriarUsuarioResponse newUser = new CriarUsuarioResponse(usuario);

            var retorno = Set.Add(newUser.ToUsuarioModel());
            context.SaveChanges();

            return retorno.Entity;
        }
    }
}
