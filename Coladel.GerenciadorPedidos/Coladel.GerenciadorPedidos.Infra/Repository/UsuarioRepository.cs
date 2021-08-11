using Coladel.Application.Handlers.Usuarios.Response;
using Coladel.GerenciadorPedidos.Domain.Body;
using Coladel.GerenciadorPedidos.Domain.Entidades;
using Coladel.GerenciadorPedidos.Domain.Interface;
using Coladel.GerenciadorPedidos.Infra.Data;

namespace Coladel.GerenciadorPedidos.Infra.Repository
{
    public class UsuarioRepository : Repository<Usuario>, IUsuarioRepository
    {
        public UsuarioRepository(ApplicationDbContext context) : base(context) { }
        
        public Usuario CriarUsuario(CriarUsuarioRequestBody usuario)
        {
            var retorno = Set.Add(usuario.ToModel());
            context.SaveChanges();

            return retorno.Entity;
        }
    }
}
