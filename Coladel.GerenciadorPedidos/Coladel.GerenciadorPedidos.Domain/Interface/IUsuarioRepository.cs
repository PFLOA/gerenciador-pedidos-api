using Coladel.GerenciadorPedidos.Domain.Body;
using Coladel.GerenciadorPedidos.Domain.Entidades;

namespace Coladel.GerenciadorPedidos.Domain.Interface
{
    public interface IUsuarioRepository
    {
        Usuario CriarUsuario(CriarUsuarioRequestBody usuario);
    }
}
